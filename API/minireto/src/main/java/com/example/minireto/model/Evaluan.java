package com.example.minireto.model;

public class Evaluan {

    private int id;
    private float calificacion_pers;
    private String comentario;
    private Proyecto proyecto;
    private Profesor profesor;

    public Evaluan(int id, float calificacion_pers, String comentario, Proyecto proyecto, Profesor profesor) {
        this.id = id;
        this.calificacion_pers = calificacion_pers;
        this.comentario = comentario;
        this.proyecto = proyecto;
        this.profesor = profesor;
    }

    public Evaluan(){

    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public float getCalificacion_pers() {
        return calificacion_pers;
    }

    public void setCalificacion_pers(float calificacion_pers) {
        this.calificacion_pers = calificacion_pers;
    }

    public String getComentario() {
        return comentario;
    }

    public void setComentario(String comentario) {
        this.comentario = comentario;
    }

    public Proyecto getProyecto() {
        return proyecto;
    }

    public void setProyecto(Proyecto proyecto) {
        this.proyecto = proyecto;
    }

    public Profesor getProfesor() {
        return profesor;
    }

    public void setProfesor(Profesor profesor) {
        this.profesor = profesor;
    }
}
