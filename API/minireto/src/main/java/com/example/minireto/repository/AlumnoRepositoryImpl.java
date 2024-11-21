package com.example.minireto.repository;


import com.example.minireto.model.Alumno;
import com.example.minireto.repository.Interfaces.AlumnoRepository;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Repository;

import java.util.List;
@Repository
public class AlumnoRepositoryImpl implements AlumnoRepository {

   private final JdbcTemplate jdbcTemplate;

    public AlumnoRepositoryImpl(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public List<Alumno> findAll() {
        return List.of();
    }

    @Override
    public Alumno findById(String id) {
        return null;
    }

    @Override
    public Alumno findByDni(String dni) {
        return null;
    }

    @Override
    public int save(Alumno alumno) {
        return 0;
    }

    @Override
    public int update(Alumno alumno) {
        return 0;
    }

    @Override
    public int delete(String id) {
        return 0;
    }
}
