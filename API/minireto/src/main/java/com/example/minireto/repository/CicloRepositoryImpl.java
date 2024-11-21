package com.example.minireto.repository;

import com.example.minireto.repository.Interfaces.CicloRepository;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class CicloRepositoryImpl implements CicloRepository {

    private final JdbcTemplate jdbcTemplate;

    public CicloRepositoryImpl(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
    }



    @Override
    public CicloRepository findById(String id) {
        return null;
    }
}
