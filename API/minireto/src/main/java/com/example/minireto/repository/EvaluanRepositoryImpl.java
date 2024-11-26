package com.example.minireto.repository;

import com.example.minireto.model.Evaluan;
import com.example.minireto.model.Profesor;
import com.example.minireto.model.Proyecto;
import com.example.minireto.model.Realizan;
import com.example.minireto.repository.interfaces.EvaluanRepository;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;
import java.util.UUID;

@Repository
public class EvaluanRepositoryImpl implements EvaluanRepository {

    private final JdbcTemplate jdbcTemplate;
    private static ProyectoRepositoryImpl proyectoRepository;
    private static ProfesorRepositoryImpl profesorRepository;
    public EvaluanRepositoryImpl(JdbcTemplate jdbcTemplate){
        this.jdbcTemplate = jdbcTemplate;
        proyectoRepository = new ProyectoRepositoryImpl(jdbcTemplate);
        profesorRepository = new ProfesorRepositoryImpl(jdbcTemplate);
    }

    @Override
    public List<Evaluan> findAll() {
        return jdbcTemplate.query("SELECT id, calificacion_pers, comentario, proyecto, profesor FROM evaluan", new EvaluanRowMapper());
    }

    @Override
    public Evaluan findById(int id) {
        return jdbcTemplate.queryForObject("SELECT id, calificacion_pers, comentario, proyecto, profesor FROM evaluan where id = ?", new EvaluanRepositoryImpl.EvaluanRowMapper(), id);
    }

    @Override
    public Evaluan findByIdProyecto(int id) {
        return jdbcTemplate.queryForObject("SELECT id, calificacion_pers, comentario, proyecto, profesor FROM evaluan where proyecto = ?", new EvaluanRepositoryImpl.EvaluanRowMapper(), id);
    }

    @Override
    public Evaluan findByIdProfesor(String id) {
        return jdbcTemplate.queryForObject("SELECT id, calificacion_pers, comentario, proyecto, profesor FROM evaluan where profesor = ?", new EvaluanRepositoryImpl.EvaluanRowMapper(), id);
    }

    @Override
    public int save(Evaluan evaluan) {
        evaluan.setId(UUID.randomUUID().variant());
        String sql = "INSERT INTO realizan (id, calificacion_pers, comentario, proyecto, profesor) VALUES (?,?,?,?,?)";
        return jdbcTemplate.update(sql, evaluan.getId(), evaluan.getCalificacion_pers(), evaluan.getComentario(), evaluan.getProyecto().getIdproyecto(), evaluan.getProfesor().getIdprofesor());
    }

    @Override
    public int update(Evaluan evaluan) {
        return jdbcTemplate.update("UPDATE realizan SET calificacion_pers = ?, comentario = ?, proyecto = ?, profesor = ? WHERE id = ?",
                evaluan.getCalificacion_pers(), evaluan.getComentario(), evaluan.getProyecto().getIdproyecto(), evaluan.getProfesor().getIdprofesor(), evaluan.getId());
    }

    @Override
    public int deleteById(int id) {
        return jdbcTemplate.update("DELETE FROM evaluan WHERE id = ?", id);
    }
    private  static  class  EvaluanRowMapper implements  RowMapper<Evaluan>{
         @Override
        public  Evaluan mapRow(ResultSet rs, int rowNum) throws SQLException {
             Evaluan evaluan = new Evaluan();
             evaluan.setId(rs.getInt("id"));
             evaluan.setCalificacion_pers(rs.getInt("calificacion_pers"));
             evaluan.setComentario(rs.getString("comentario"));
             Profesor profesor = profesorRepository.findById(rs.getString("profesor"));
             evaluan.setProfesor(profesor);
             Proyecto proyecto = proyectoRepository.findById(rs.getInt("proyecto"));
             evaluan.setProyecto(proyecto);

             return evaluan;
         }
    }



}
