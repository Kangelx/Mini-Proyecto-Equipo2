package com.example.minireto.model;

import com.example.minireto.ENUMS.GENERO;

import java.sql.Date;

public class Profesor {

    private String idprofesor;
    private String nombre;
    private String apellidos;
    private String dni;
    private String email;
    private String password_encr;
    private String telefono;
    private GENERO genero;
    private Date fechaNac;
    private String especialidad;
    private boolean activo;
    private boolean admin;

    public Profesor() {
    }

    public Profesor(String idprofesor, String nombre, String apellidos, String dni, String email, String password_encr, String telefono, Date fechaNac, GENERO genero, String especialidad, boolean activo, boolean admin) {
        this.idprofesor = idprofesor;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.dni = dni;
        this.email = email;
        this.password_encr = password_encr;
        this.telefono = telefono;
        this.fechaNac = fechaNac;
        this.genero = genero;
        this.especialidad = especialidad;
        this.activo = activo;
        this.admin = admin;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getEspecialidad() {
        return especialidad;
    }

    public void setEspecialidad(String especialidad) {
        this.especialidad = especialidad;
    }

    public Date getFechaNac() {
        return fechaNac;
    }

    public void setFechaNac(Date fechaNac) {
        this.fechaNac = fechaNac;
    }

    public boolean isAdmin() {
        return admin;
    }

    public void setAdmin(boolean admin) {
        this.admin = admin;
    }

    public GENERO getGenero() {
        return genero;
    }

    public void setGenero(GENERO genero) {
        this.genero = genero;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getPassword_encr() {
        return password_encr;
    }

    public void setPassword_encr(String password_encr) {
        this.password_encr = password_encr;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getIdprofesor() {
        return idprofesor;
    }

    public void setIdprofesor(String idprofesor) {
        this.idprofesor = idprofesor;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }
}
