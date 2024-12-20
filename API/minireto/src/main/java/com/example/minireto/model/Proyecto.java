package com.example.minireto.model;

import com.example.minireto.ENUMS.TIPO;

import java.sql.Date;

public class Proyecto {

    private int idproyecto;
    private String nombre;
    private String tipo;
    private String resumen;
    private int anno_acad;
    private Date fecha_pres;
    private String logo;
    private String memoria;
    private String archivos;
    private String comentarios;
    private Ciclo ciclo;
    private Profesor tutor;

    public Proyecto(){

    }

    public Proyecto(int idproyecto, Profesor tutor, Ciclo ciclo, String archivos, String memoria, String comentarios, String logo, int anno_acad, Date fecha_pres, String resumen, String tipo, String nombre) {
        this.idproyecto = idproyecto;
        this.tutor = tutor;
        this.ciclo = ciclo;
        this.archivos = archivos;
        this.memoria = memoria;
        this.comentarios = comentarios;
        this.logo = logo;
        this.anno_acad = anno_acad;
        this.fecha_pres = fecha_pres;
        this.resumen = resumen;
        this.tipo = tipo;
        this.nombre = nombre;
    }

    public Profesor getTutor() {
        return tutor;
    }

    public void setTutor(Profesor tutor) {
        this.tutor = tutor;
    }

    public Ciclo getCiclo() {
        return ciclo;
    }

    public void setCiclo(Ciclo ciclo) {
        this.ciclo = ciclo;
    }

    public String getComentarios() {
        return comentarios;
    }

    public void setComentarios(String comentarios) {
        this.comentarios = comentarios;
    }

    public String getArchivos() {
        return archivos;
    }

    public void setArchivos(String archivos) {
        this.archivos = archivos;
    }

    public String getMemoria() {
        return memoria;
    }

    public void setMemoria(String memoria) {
        this.memoria = memoria;
    }

    public String getLogo() {
        return logo;
    }

    public void setLogo(String logo) {
        this.logo = logo;
    }

    public Date getFecha_pres() {
        return fecha_pres;
    }

    public void setFecha_pres(Date fecha_pres) {
        this.fecha_pres = fecha_pres;
    }

    public int getAnno_acad() {
        return anno_acad;
    }

    public void setAnno_acad(int anno_acad) {
        this.anno_acad = anno_acad;
    }

    public String getResumen() {
        return resumen;
    }

    public void setResumen(String resumen) {
        this.resumen = resumen;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getIdproyecto() {
        return idproyecto;
    }

    public void setIdproyecto(int idproyecto) {
        this.idproyecto = idproyecto;
    }
}
