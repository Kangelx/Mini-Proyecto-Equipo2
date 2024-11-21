package com.example.minireto.model;

public class Evaluan {

    private int id;
    private float calificacion_pers;
    private String comentario;
    private int proyecto;
    private String profesor;

    public Evaluan(int id, float calificacion_pers, String comentario, int proyecto, String profesor) {
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

    public int getProyecto() {
        return proyecto;
    }

    public void setProyecto(int proyecto) {
        this.proyecto = proyecto;
    }

    public String getProfesor() {
        return profesor;
    }

    public void setProfesor(String profesor) {
        this.profesor = profesor;
    }
}
