package com.example.minireto.repository;

import com.example.minireto.ENUMS.ETAPA;
import com.example.minireto.ENUMS.FAMILIA;
import com.example.minireto.model.Ciclo;
import com.example.minireto.model.Realizan;
import com.example.minireto.repository.Interfaces.CicloRepository;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

@Repository
public class CicloRepositoryImpl implements CicloRepository {

    private final JdbcTemplate jdbcTemplate;

    public CicloRepositoryImpl(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public Ciclo findById(String id) {
        return jdbcTemplate.queryForObject("SELECT * FROM ciclos where codciclo = ?", new CicloRepositoryImpl.CicloRowMapper(), id);
    }

    private static class CicloRowMapper implements RowMapper<Ciclo> {

        @Override
        public Ciclo mapRow(ResultSet rs, int rowNum) throws SQLException {
            Ciclo ciclo = new Ciclo();
            ciclo.setCodCiclo(rs.getString("codciclo"));
            ciclo.setNombre(rs.getString("nombre"));
            ciclo.setEtapa(ETAPA.valueOf(rs.getString("etapa").toUpperCase()));
            ciclo.setTitulo(rs.getString("titulo"));
            ciclo.setCurriculo(rs.getString("curriculo"));
            ciclo.setFamilia(FAMILIA.valueOf(rs.getString("familia").toUpperCase()));
            return ciclo;

        }

    }
}
