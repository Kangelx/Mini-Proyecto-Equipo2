package com.example.minireto.model;

import com.example.minireto.ENUMS.ETAPA;
import com.example.minireto.ENUMS.FAMILIA;

public class Ciclo {
    private String codCiclo;
    private String nombre;
    private ETAPA etapa;
    private String titulo;
    private String curriculo;
    private FAMILIA familia;

    public Ciclo() {
    }

    public String getCodCiclo() {
        return codCiclo;
    }

    public void setCodCiclo(String codCiclo) {
        this.codCiclo = codCiclo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public ETAPA getEtapa() {
        return etapa;
    }

    public void setEtapa(ETAPA etapa) {
        this.etapa = etapa;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getCurriculo() {
        return curriculo;
    }

    public void setCurriculo(String curriculo) {
        this.curriculo = curriculo;
    }

    public FAMILIA getFamilia() {
        return familia;
    }

    public void setFamilia(FAMILIA familia) {
        this.familia = familia;
    }
}
