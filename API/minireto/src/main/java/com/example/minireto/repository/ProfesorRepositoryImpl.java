package com.example.minireto.repository;

import com.example.minireto.ENUMS.GENERO;
import com.example.minireto.model.Profesor;
import com.example.minireto.repository.interfaces.ProfesorRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

@Repository
public class ProfesorRepositoryImpl implements ProfesorRepository {

    private final JdbcTemplate jdbcTemplate;

    public ProfesorRepositoryImpl(JdbcTemplate jdbcTemplate){
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public List<Profesor> findAll() {
        return jdbcTemplate.query(" SELECT * FROM profesores", new ProfesorRowWrapper());
    }

    @Override
    public Profesor findById(String id) {
        return jdbcTemplate.queryForObject("SELECT * FROM profesores where idprofesor = ?", new ProfesorRowWrapper(), id);
    }

    @Override
    public Profesor findByDni(String dni) {
        return jdbcTemplate.queryForObject("SELECT * FROM profesores where dni = ?", new ProfesorRowWrapper(), dni);
    }

    @Override
    public int save(Profesor profesor) {
        String sql = "INSERT INTO profesores (nombre, apellidos, dni, email, password_encr, telefono, genero, fechaNac, especialidad, activo, admin) "+
                "Values (?, ?, ?, ?, md5(?), ?, ?, ?, ?, ?, ?)";

        return jdbcTemplate.update(sql, profesor.getNombre(), profesor.getApellidos(), profesor.getDni(), profesor.getEmail(), profesor.getPassword_encr(), profesor.getTelefono(), profesor.getGenero(), profesor.getFechaNac(), profesor.getEspecialidad(), profesor.isActivo(), profesor.isAdmin());
    }

    @Override
    public int update(Profesor profesor) {
        try{
            return jdbcTemplate.update(
                    "UPDATE profesores SET nombre = ?, apellidos = ?, dni = ?, email = ?, password_encr = md5(?), telefono = ?, genero = ?, fechaNac = ?, especialidad = ?, activo = ?, admin = ? " +
                            " WHERE idProfesor = ?",
                    profesor.getNombre(), profesor.getApellidos(), profesor.getDni(), profesor.getEmail(), profesor.getPassword_encr(), profesor.getTelefono(), profesor.getGenero(), profesor.getFechaNac(), profesor.getEspecialidad(), profesor.isActivo(), profesor.isAdmin(), profesor.getIdprofesor()

            );
        }catch (Exception e){
            return -1;
        }
    }

    @Override
    public int deleteById(String id) {
        return jdbcTemplate.update("DELETE FROM profesores WHERE idprofesor = ?", id);
    }


    private static class ProfesorRowWrapper implements RowMapper<Profesor> {

        @Override
        public Profesor mapRow(ResultSet rs, int rowNum) throws SQLException {
            Profesor profesor = new Profesor();

            profesor.setIdprofesor(rs.getString("idprofesor"));
            profesor.setNombre(rs.getString("nombre"));
            profesor.setApellidos(rs.getString("apellidos"));
            profesor.setDni(rs.getString("dni"));
            profesor.setEmail(rs.getString("email"));
            profesor.setPassword_encr(rs.getString("password_encr"));
            profesor.setTelefono(rs.getString("telefono"));
            profesor.setGenero(GENERO.valueOf(rs.getString("genero").toUpperCase()));
            profesor.setFechaNac(rs.getDate("fechaNac"));
            profesor.setEspecialidad(rs.getString("especialidad"));
            profesor.setActivo(rs.getBoolean("activo"));
            profesor.setAdmin(rs.getBoolean("admin"));

            return profesor;
        }
    }
}
