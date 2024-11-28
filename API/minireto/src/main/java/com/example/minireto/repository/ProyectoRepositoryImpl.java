package com.example.minireto.repository;

import com.example.minireto.ENUMS.ETAPA;
import com.example.minireto.ENUMS.FAMILIA;
import com.example.minireto.ENUMS.GENERO;
import com.example.minireto.ENUMS.TIPO;
import com.example.minireto.model.Alumno;
import com.example.minireto.model.Ciclo;
import com.example.minireto.model.Profesor;
import com.example.minireto.model.Proyecto;
import com.example.minireto.repository.interfaces.ProyectoRepository;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.time.LocalDate;
import java.util.List;

@Repository
public class ProyectoRepositoryImpl implements ProyectoRepository {

    private final JdbcTemplate jdbcTemplate;

    public ProyectoRepositoryImpl(JdbcTemplate jdbcTemplate){
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public List<Proyecto> findAll() {

        return jdbcTemplate.query(" SELECT * FROM proyectos inner join ciclos on codciclo = ciclo inner join profesores on idprofesor = tutor", new ProyectoRowMapper());
    }

    @Override
    public Proyecto findById(int id) {
        return jdbcTemplate.queryForObject("SELECT * FROM proyectos inner join ciclos on codciclo = ciclo inner join profesores on idprofesor = tutor where idproyecto = ?", new ProyectoRowMapper(), id);
    }

    @Override
    public int save(Proyecto proyecto) {
        String sql = "INSERT INTO proyectos (nombre, tipo, resumen, anno_acad, fecha_pres, logo, memoria, archivos, comentarios, ciclo, tutor) "+
                "Values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

        return jdbcTemplate.update(sql, proyecto.getNombre(), proyecto.getTipo(), proyecto.getResumen(), proyecto.getAnno_acad(), proyecto.getFecha_pres(), proyecto.getLogo(), proyecto.getMemoria(), proyecto.getComentarios(), proyecto.getCiclo().getCodCiclo(), proyecto.getTutor().getIdprofesor());
    }

    @Override
    public int update(Proyecto proyecto) {
        try{
            return jdbcTemplate.update(
                    "UPDATE proyectos SET nombre = ?, tipo = ?, resumen = ?, anno_acad = ?, fecha_pres = ?, logo = ?, memoria = ?, archivos = ?, comentarios = ?, ciclo = ?, tutor = ? " +
                            " WHERE idProfesor = ?",
                    proyecto.getNombre(), proyecto.getTipo(), proyecto.getResumen(), proyecto.getAnno_acad(), proyecto.getFecha_pres(), proyecto.getLogo(), proyecto.getMemoria(), proyecto.getComentarios(), proyecto.getCiclo().getCodCiclo(), proyecto.getTutor().getIdprofesor()

            );
        }catch (Exception e){
            return -1;
        }
    }

    @Override
    public int deleteById(int id) {

        return jdbcTemplate.update("DELETE FROM proyectos WHERE idproyecto = ?", id);
    }

    private static class ProyectoRowMapper implements RowMapper<Proyecto> {
        @Override
        public Proyecto mapRow(ResultSet rs, int rowNum) throws SQLException {
            Proyecto proyecto = new Proyecto();
            Ciclo ciclo = new Ciclo();
            Profesor profesor = new Profesor();

            ciclo.setCodCiclo(rs.getString("codciclo"));
            ciclo.setNombre(rs.getString("nombre"));
            ciclo.setEtapa(ETAPA.valueOf(rs.getString("etapa")));
            ciclo.setTitulo(rs.getString("titulo"));
            ciclo.setCurriculo(rs.getString("curriculo"));
            ciclo.setFamilia(FAMILIA.valueOf(rs.getString("familia")));

            profesor.setIdprofesor(rs.getString("idprofesor"));
            profesor.setNombre(rs.getString("nombre"));
            profesor.setApellidos(rs.getString("apellidos"));
            profesor.setDni(rs.getString("dni"));
            profesor.setEmail(rs.getString("email"));
            profesor.setPassword_encr(rs.getString("password_encr"));
            profesor.setTelefono(rs.getString("telefono"));
            profesor.setGenero(GENERO.valueOf(rs.getString("genero")));
            profesor.setFechaNac(rs.getDate("fechaNac"));
            profesor.setEspecialidad(rs.getString("especialidad"));
            profesor.setActivo(rs.getBoolean("activo"));
            profesor.setAdmin(rs.getBoolean("admin"));

            proyecto.setIdproyecto(rs.getInt("idproyecto"));
            proyecto.setNombre(rs.getString("nombre"));
            proyecto.setTipo((rs.getString("tipo")));
            proyecto.setResumen(rs.getString("resumen"));
            proyecto.setAnno_acad(rs.getInt("anno_acad"));
            proyecto.setFecha_pres(rs.getDate("fecha_pres"));
            proyecto.setLogo(rs.getString("logo"));
            proyecto.setMemoria(rs.getString("memoria"));
            proyecto.setArchivos(rs.getString("archivos"));
            proyecto.setComentarios(rs.getString("comentarios"));
            proyecto.setCiclo(ciclo);
            proyecto.setTutor(profesor);



            return proyecto;

        }

    }
}




