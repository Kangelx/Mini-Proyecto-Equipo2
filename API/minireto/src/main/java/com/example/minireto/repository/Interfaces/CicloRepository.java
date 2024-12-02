package com.example.minireto.repository.Interfaces;

import com.example.minireto.model.Alumno;
import com.example.minireto.model.Ciclo;
import com.example.minireto.model.Evaluan;

import java.util.List;

public interface CicloRepository {

    //Metodo para obtener todos los ciclos
    List<Ciclo> findAll();
    //Metodo para obtener un ciclo por su codigo
    Ciclo findById(String id);
    //Método para guardar una evaluacion
    int save(Ciclo ciclo);
    //Método para actualizar una evaluacion existente
    int update(Ciclo ciclo);
    //Método para eliminar una evaluacion por su id
    int deleteById(String id);
}
