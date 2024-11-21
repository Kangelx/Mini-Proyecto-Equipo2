package com.example.minireto.repository;

import com.example.minireto.model.Profesor;
import com.example.minireto.repository.interfaces.ProfesorRepository;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class ProfesorRepositoryImpl implements ProfesorRepository {

    private final JdbcTemplate jdbcTemplate;

    public ProfesorRepositoryImpl(JdbcTemplate jdbcTemplate){
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public List<Profesor> findAll() {
        return List.of();
    }

    @Override
    public Profesor findById(String id) {
        return null;
    }

    @Override
    public Profesor findByDni(String dni) {
        return null;
    }

    @Override
    public int save(Profesor profesor) {
        return 0;
    }

    @Override
    public int update(Profesor profesor) {
        return 0;
    }

    @Override
    public int deleteById(String id) {
        return 0;
    }
}
