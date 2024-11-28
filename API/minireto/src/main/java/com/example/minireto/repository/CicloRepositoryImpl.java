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
    public List<Ciclo> findAll() {
        return jdbcTemplate.query("SELECT cdciclo, nombre, etapa, titulo, curriculo, familia FROM ciclos", new CicloRepositoryImpl.CicloRowMapper());
    }

    @Override
    public Ciclo findById(String id) {
        return jdbcTemplate.queryForObject("SELECT cdciclo, nombre, etapa, titulo, curriculo, familia FROM ciclos where codciclo = ?", new CicloRepositoryImpl.CicloRowMapper(), id);
    }

    @Override
    public int save(Ciclo ciclo) {
        String sql = "INSERT INTO ciclo (cdciclo, nombre, etapa, titulo, curriculo, familia) VALUES (?,?,?,?,?, ?)";
        return jdbcTemplate.update(sql, ciclo.getCodCiclo(), ciclo.getNombre(), ciclo.getEtapa(), ciclo.getTitulo(), ciclo.getFamilia());
    }

    @Override
    public int update(Ciclo ciclo) {
        return jdbcTemplate.update("UPDATE ciclo SET cdciclo = ?, nombre = ?, etapa = ?, titulo = ?, curriculo = ?, familia = ? WHERE cdciclo = ?",
                ciclo.getCodCiclo(), ciclo.getNombre(), ciclo.getEtapa(), ciclo.getTitulo(), ciclo.getFamilia(), ciclo.getCodCiclo());
    }

    @Override
    public int deleteById(String id) {
        return jdbcTemplate.update("DELETE FROM ciclo WHERE cdciclo = ?", id);
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
