package com.example.minireto.controller;

import com.example.minireto.model.Ciclo;
import com.example.minireto.model.Evaluan;
import com.example.minireto.model.Realizan;
import com.example.minireto.repository.Interfaces.CicloRepository;
import com.example.minireto.repository.Interfaces.RealizanRepository;
import com.example.minireto.repository.RealizanRepositoryImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/ciclo")
public class CicloController {
    @Autowired
    private CicloRepository cicloRepository;


    @GetMapping
    public ResponseEntity<?> getAllCiclos() {
        List<Ciclo> ciclo = cicloRepository.findAll();
        if(ciclo.isEmpty()){
            return ResponseEntity.notFound().build();
        }else{
            return ResponseEntity.ok(ciclo);
        }
    }

    @GetMapping("/{id}")
    public ResponseEntity<?> getCicloById(@PathVariable("id") String id) {
        Ciclo ciclo = cicloRepository.findById(id);
        if(ciclo == null){
            return ResponseEntity.notFound().build();
        }else {
            return ResponseEntity.ok(ciclo);
        }
    }

    @PostMapping
    public ResponseEntity<?> createEvaluan(@RequestBody Ciclo ciclo) {
        if (cicloRepository.save(ciclo) ==1)
            return ResponseEntity.status(HttpStatus.CREATED).body(ciclo);
        else
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("No se pudo insertar.");
    }

    @PutMapping("/{id}")
    public ResponseEntity<?> updateEvaluan(@PathVariable String id, @RequestBody Ciclo ciclo) {
        Ciclo cicloExiste = cicloRepository.findById(id);
        if(cicloExiste == null){
            return ResponseEntity.notFound().build();
        }else{
            ciclo.setCodCiclo(id);
            cicloRepository.update(ciclo);
            return ResponseEntity.ok(cicloExiste);
        }
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<?> deleteEvaluan(@PathVariable String id) {
        Ciclo ciclo = cicloRepository.findById(id);
        if (ciclo == null) {
            return ResponseEntity.notFound().build();
        } else {
            cicloRepository.deleteById(id);
            return ResponseEntity.ok().build();
        }
    }
}
