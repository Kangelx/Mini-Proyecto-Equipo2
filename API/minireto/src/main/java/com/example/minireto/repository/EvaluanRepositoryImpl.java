package com.example.minireto.repository;

import com.example.minireto.model.Evaluan;
import com.example.minireto.repository.interfaces.EvaluanRepository;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class EvaluanRepositoryImpl implements EvaluanRepository {

    private final JdbcTemplate jdbcTemplate;

    public EvaluanRepositoryImpl(JdbcTemplate jdbcTemplate){
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public List<Evaluan> findAll() {
        return List.of();
    }

    @Override
    public Evaluan findById(int id) {
        return null;
    }

    @Override
    public Evaluan findByIdProyecto(int id) {
        return null;
    }

    @Override
    public Evaluan findByIdProfesor(String id) {
        return null;
    }

    @Override
    public int save(Evaluan profesor) {
        return 0;
    }

    @Override
    public int update(Evaluan profesor) {
        return 0;
    }

    @Override
    public int deleteById(int id) {
        return 0;
    }
}
