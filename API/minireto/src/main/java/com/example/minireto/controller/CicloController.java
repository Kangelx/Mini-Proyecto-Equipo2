package com.example.minireto.controller;

import com.example.minireto.model.Ciclo;
import com.example.minireto.model.Realizan;
import com.example.minireto.repository.Interfaces.CicloRepository;
import com.example.minireto.repository.Interfaces.RealizanRepository;
import com.example.minireto.repository.RealizanRepositoryImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/ciclo")
public class CicloController {
    @Autowired
    private CicloRepository cicloRepository;



    @GetMapping("/{id}")
    public ResponseEntity<?> getCicloById(@PathVariable("id") String id) {
        Ciclo ciclo = cicloRepository.findById(id);
        if(ciclo == null){
            return ResponseEntity.notFound().build();
        }else {
            return ResponseEntity.ok(ciclo);
        }
    }
}
