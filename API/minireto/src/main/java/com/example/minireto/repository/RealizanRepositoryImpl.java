package com.example.minireto.repository;

import com.example.minireto.model.Realizan;
import com.example.minireto.repository.Interfaces.RealizanRepository;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Repository;

@Repository
public class RealizanRepositoryImpl implements RealizanRepository {
    private  final JdbcTemplate jdbcTemplate;

    public RealizanRepositoryImpl(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public Realizan findById(int id) {
        return null;
    }

    @Override
    public int save(Realizan realizan) {
        return 0;
    }

    @Override
    public int update(Realizan realizan) {
        return 0;
    }

    @Override
    public int delete(int id) {
        return 0;
    }
}
