package com.example.minireto.repository.Interfaces;

import com.example.minireto.model.Alumno;

import java.util.List;

public interface AlumnoRepository {
    //Metodo para obtener todos los alumnos
    List<Alumno> findAll();
    //Metodo para obtener un alumno por su ID
    Alumno findById(String id);
    //Metodo para obtener alumno por DNI
    Alumno findByDni(String dni);
    //Metodo para guardar un alumno
    int save(Alumno alumno);
    //Metodo apra actualizar un alumno
    int update(Alumno alumno);
    //Metodo para eliminar un alumno por us id
    int delete(String id);
}
