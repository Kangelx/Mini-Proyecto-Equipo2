package com.example.minireto.controller;

import com.example.minireto.model.Alumno;
import com.example.minireto.model.Profesor;
import com.example.minireto.model.Realizan;
import com.example.minireto.repository.AlumnoRepositoryImpl;
import com.example.minireto.repository.Interfaces.RealizanRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/realizan")
public class RealizanController {

    @Autowired
    private RealizanRepository realizanRepository;
    private AlumnoRepositoryImpl alumnoRepositoryImpl;


    @PostMapping
    public ResponseEntity<?> createRealizan(@RequestBody Realizan realizan) {
        if (realizanRepository.save(realizan) ==1)
            return ResponseEntity.status(HttpStatus.CREATED).body(realizan);
        else
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("No se pudo insertar.");
    }

    @GetMapping("/{id}")
    public ResponseEntity<?> getRealizanById(@PathVariable("id") int id) {
        Realizan realizan = realizanRepository.findById(id);
        if(realizan == null){
            return ResponseEntity.notFound().build();
        }else {
            return ResponseEntity.ok(realizan);
        }
    }
    @PutMapping("/{id}")
    public ResponseEntity<?> updateRealizan(@PathVariable("id") int id, @RequestBody Realizan realizan) {
        Realizan realizanExiste = realizanRepository.findById(id);
        if(realizanExiste == null){
            return ResponseEntity.notFound().build();
        }else{
            realizan.setId(id);
            realizanRepository.update(realizan);
            return ResponseEntity.ok(realizanExiste);
        }
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<?> deleteRealizan(@PathVariable("id") int id) {
        Realizan realizan = realizanRepository.findById(id);
        if (realizan == null) {
            return ResponseEntity.notFound().build();
        } else {
            realizanRepository.delete(id);
            return ResponseEntity.ok().build();
        }
    }
}
