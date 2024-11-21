package com.example.minireto.repository.Interfaces;

import java.util.List;

public interface CicloRepository {

    //Metodo para obtener un ciclo por su codigo
    CicloRepository findById(String id);
}
