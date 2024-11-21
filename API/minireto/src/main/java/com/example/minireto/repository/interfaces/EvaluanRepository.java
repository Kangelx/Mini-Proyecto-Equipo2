package com.example.minireto.repository.interfaces;

import com.example.minireto.model.Evaluan;

import java.util.List;

public interface EvaluanRepository {
    //Método para obtener todas las evaluaciones
    List<Evaluan> findAll();
    //Método para obtener una evaluacion por su id
    Evaluan findById(int id);
    //Método para obtener las evaluaciones por la id de proyecto
    Evaluan findByIdProyecto(int id);
    //Método para obtener las evaluaciones por la id del profesor
    Evaluan findByIdProfesor(String id);
    //Método para guardar una evaluacion
    int save(Evaluan profesor);
    //Método para actualizar una evaluacion existente
    int update(Evaluan profesor);
    //Método para eliminar una evaluacion por su id
    int deleteById(int id);
}
