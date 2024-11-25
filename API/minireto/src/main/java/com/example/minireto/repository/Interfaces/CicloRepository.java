package com.example.minireto.repository.Interfaces;

import com.example.minireto.model.Ciclo;

import java.util.List;

public interface CicloRepository {

    //Metodo para obtener un ciclo por su codigo
    Ciclo findById(String id);

}
