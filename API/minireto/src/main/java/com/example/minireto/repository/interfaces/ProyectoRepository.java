package com.example.minireto.repository.interfaces;

import com.example.minireto.model.Profesor;
import com.example.minireto.model.Proyecto;

import java.util.List;

public interface ProyectoRepository {
    //Método para obtener todos los proyectos
    List<Proyecto> findAll();
    //Método para obtener un proyecto por su id
    Proyecto findById(int id);
    //Método para guardar un nuevo proyecto
    int save(Proyecto proyecto);
    //Método para actualizar un proyecto existente
    int update(Proyecto proyecto);
    //Método para eliminar un proyecto por su ID
    int deleteById(int id);
}
