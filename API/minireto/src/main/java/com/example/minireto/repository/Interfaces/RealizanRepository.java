package com.example.minireto.repository.Interfaces;

import com.example.minireto.model.Realizan;

public interface RealizanRepository {
    //Metodo para obtener quien realiza el proyecto
    Realizan findById(int id);
    //Metodo para guardar realizan
    int save(Realizan realizan);
    //Metodo para actualizar informacion de realizan
    int update(Realizan realizan);
    //Metodo para eliminar una realizacion
    int delete(int id);

}
