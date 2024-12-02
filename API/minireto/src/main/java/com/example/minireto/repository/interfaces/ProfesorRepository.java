package com.example.minireto.repository.interfaces;

import com.example.minireto.model.Profesor;

import java.util.List;

public interface ProfesorRepository {
    //Método para obtener todos los profesores
    List<Profesor> findAll();
    //Método para obtener un profesor por su id
    Profesor findById(String id);
    //Método para obtener Profesores por su DNI
    Profesor findByDni(String dni);
    //Método para guardar un nuevo profesor
    int save(Profesor profesor);
    //Método para actualizar un profesor existente
    int update(Profesor profesor);
    //Método para eliminar un proyecto por su ID
    int deleteById(String id);
}
