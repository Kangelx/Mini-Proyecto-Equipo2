package com.example.minireto.repository;


import com.example.minireto.ENUMS.ETAPA;
import com.example.minireto.ENUMS.FAMILIA;
import com.example.minireto.ENUMS.GENERO;
import com.example.minireto.model.Alumno;
import com.example.minireto.model.Ciclo;
import com.example.minireto.repository.Interfaces.AlumnoRepository;
import jakarta.websocket.Encoder;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.ResultSetExtractor;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.time.LocalDate;
import java.util.List;
import java.util.UUID;

@Repository
public class AlumnoRepositoryImpl implements AlumnoRepository {

    private final JdbcTemplate jdbcTemplate;


    public AlumnoRepositoryImpl(JdbcTemplate jdbcTemplate){
        this.jdbcTemplate = jdbcTemplate;

    }




    @Override
    public List<Alumno> findAll() {

        return jdbcTemplate.query("SELECT idalumno,alumnos.nombre as alnombre, apellidos, dni, email, password_encr, telefono, genero, fechaNac, activo," +
                " codciclo, ciclos.nombre as cnombre, etapa, titulo, " +
                "curriculo, familia  FROM alumnos INNER JOIN ciclos ON ciclo_actual = codciclo", new AlumnoRowMapper());
    }

    @Override
    public Alumno findById(String id) {
        return jdbcTemplate.queryForObject("SELECT idalumno,alumnos.nombre as alnombre, apellidos, dni, email, password_encr, telefono, genero, fechaNac, activo, codciclo, ciclos.nombre as cnombre, etapa, " +
                "titulo, curriculo, familia  FROM alumnos INNER JOIN ciclos ON ciclo_actual = codciclo WHERE idalumno = ?", new AlumnoRowMapper(), id);
    }

    @Override
    public Alumno findByDni(String dni) {
        return jdbcTemplate.queryForObject("SELECT idalumno,alumnos.nombre as alnombre, apellidos, dni, email, password_encr, telefono, genero, fechaNac, activo, codciclo, ciclos.nombre as cnombre, etapa," +
                " titulo, curriculo, familia  FROM alumnos INNER JOIN ciclos ON ciclo_actual = codciclo WHERE dni = ?", new AlumnoRowMapper(), dni);

    }

    @Override
    public int save(Alumno alumno) {
        alumno.setIdAlumno(UUID.randomUUID().toString());
        String sql = "INSERT INTO alumnos (idalumno,nombre, apellidos, dni, email, password_encr, telefono, genero, fechaNac, activo, ciclo_actual) VALUES (?,?, ?, ?,?,md5(?),?,?,?,?,?)";
        return jdbcTemplate.update(sql, alumno.getIdAlumno(),alumno.getNombre(), alumno.getApellido(), alumno.getDni(), alumno.getEmail(),alumno.getPassword(), alumno.getTelefono(), alumno.getGenero().toString(),
                alumno.getFechaNacimiento(), alumno.isActivo(), alumno.getCiclo().getCodCiclo());
    }

    @Override
    public int update(Alumno alumno) {
        return jdbcTemplate.update("UPDATE alumnos SET idalumno = ?,nombre  = ?, apellidos = ?, dni = ?, email = ? , password_encr = ?, telefono = ?, genero = ?, fechaNac = ?, activo = ?, ciclo_actual = ? " +
                "WHERE idalumno = ?", alumno.getIdAlumno(), alumno.getNombre(), alumno.getApellido(), alumno.getDni(), alumno.getEmail(),
                alumno.getPassword(), alumno.getTelefono(),alumno.getGenero().toString(), alumno.getFechaNacimiento(), alumno.isActivo(), alumno.getCiclo().getCodCiclo(), alumno.getIdAlumno());
    }

    @Override
    public int delete(String id) {
        return jdbcTemplate.update("DELETE FROM alumnos WHERE idalumno = ?", id);
    }
    private static class AlumnoRowMapper implements RowMapper<Alumno> {
        @Override
        public Alumno mapRow(ResultSet rs, int rowNum) throws SQLException {
            Alumno alumno = new Alumno();
            Ciclo ciclo = new Ciclo();

            alumno.setIdAlumno(rs.getString("idalumno"));
            alumno.setNombre(rs.getString("alnombre"));
            alumno.setApellido(rs.getString("apellidos"));
            alumno.setDni(rs.getString("dni"));
            alumno.setEmail(rs.getString("email"));
            alumno.setPassword(rs.getString("password_encr"));
            alumno.setTelefono(rs.getString("telefono"));
            alumno.setGenero(GENERO.valueOf(rs.getString("genero").toUpperCase()));
            LocalDate fechaNacimiento = rs.getDate("fechaNac").toLocalDate();
            alumno.setFechaNacimiento(fechaNacimiento);
            alumno.setActivo(rs.getBoolean("activo"));
            ciclo.setCodCiclo(rs.getString("codciclo"));
            ciclo.setNombre(rs.getString("cnombre"));
            ciclo.setEtapa(ETAPA.valueOf(rs.getString("etapa")));
            ciclo.setTitulo(rs.getString("titulo"));
            ciclo.setCurriculo(rs.getString("curriculo"));
            ciclo.setFamilia(FAMILIA.valueOf(rs.getString("familia").toUpperCase()));
            alumno.setCiclo(ciclo);

            return alumno;

        }

    }
}


