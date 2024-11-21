package com.example.minireto.repository;

import com.example.minireto.model.Proyecto;
import com.example.minireto.repository.interfaces.ProyectoRepository;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class ProyectoRepositoryImpl implements ProyectoRepository {

    private final JdbcTemplate jdbcTemplate;

    public ProyectoRepositoryImpl(JdbcTemplate jdbcTemplate){
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public List<Proyecto> findAll() {
        return List.of();
    }

    @Override
    public Proyecto findById(int id) {
        return null;
    }

    @Override
    public int save(Proyecto proyecto) {
        return 0;
    }

    @Override
    public int update(Proyecto proyecto) {
        return 0;
    }

    @Override
    public int deleteById(int id) {
        return 0;
    }
}
