package com.example.minireto.repository;

import com.example.minireto.ENUMS.ETAPA;
import com.example.minireto.ENUMS.FAMILIA;
import com.example.minireto.ENUMS.GENERO;
import com.example.minireto.model.Alumno;
import com.example.minireto.model.Ciclo;
import com.example.minireto.model.Realizan;
import com.example.minireto.repository.Interfaces.RealizanRepository;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.time.LocalDate;
import java.util.List;
import java.util.UUID;

@Repository
public class RealizanRepositoryImpl implements RealizanRepository {
    private  final JdbcTemplate jdbcTemplate;;
    private static AlumnoRepositoryImpl alumnoRepository;
    private static ProyectoRepositoryImpl proyectoRepository;

    public RealizanRepositoryImpl(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
        alumnoRepository = new AlumnoRepositoryImpl(jdbcTemplate);
        proyectoRepository = new ProyectoRepositoryImpl(jdbcTemplate);
    }

    @Override
    public List<Realizan> findAll() {
        return jdbcTemplate.query("SELECT id , calificacion, alumno, proyecto, comentario  FROM realizan", new RealizanRowMapper());
    }

    @Override
    public Realizan findById(int id) {
        return jdbcTemplate.queryForObject("SELECT id , calificacion, alumno, proyecto, comentario FROM realizan where id = ?", new RealizanRepositoryImpl.RealizanRowMapper(), id);
    }

    @Override
    public int save(Realizan realizan) {
        realizan.setId(UUID.randomUUID().variant());
        String sql = "INSERT INTO realizan (id, calificacion, alumno, proyecto, comentario) VALUES (?,?,?,?,?)";
        return jdbcTemplate.update(sql, realizan.getId(), realizan.getCalificacion(), realizan.getAlumno().getIdAlumno(), realizan.getProyecto().getIdproyecto(), realizan.getComentario());
    }

    @Override
    public int update(Realizan realizan) {
        return jdbcTemplate.update("UPDATE realizan SET calificacion = ?, alumno = ?, proyecto = ?, comentario = ? WHERE id = ?",
                realizan.getCalificacion(), realizan.getAlumno().getIdAlumno(), realizan.getProyecto().getIdproyecto(), realizan.getComentario(), realizan.getId());
    }

    @Override
    public int delete(int id) {
        return jdbcTemplate.update("DELETE FROM realizan WHERE id = ?", id);
    }

    private static class RealizanRowMapper implements RowMapper<Realizan> {

        @Override
        public Realizan mapRow(ResultSet rs, int rowNum) throws SQLException {
            Realizan realizan = new Realizan();
            realizan.setId(rs.getInt("id"));
            realizan.setCalificacion(rs.getInt("calificacion"));
            realizan.setComentario(rs.getString("comentario"));
            realizan.setAlumno(alumnoRepository.findById(rs.getString("alumno")));
            realizan.setProyecto(proyectoRepository.findById(rs.getInt("proyecto")));

            return realizan;

        }

    }
}
