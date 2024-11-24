package com.example.minireto.controller;

import com.example.minireto.model.Profesor;
import com.example.minireto.repository.interfaces.ProfesorRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/profesor")
public class ProfesorController {

    @Autowired
    private ProfesorRepository profesorRepository;

    @GetMapping()
    public ResponseEntity<?> getAllProfesores(){
        List<Profesor> profesores = profesorRepository.findAll();
        if (profesores.isEmpty())
            return ResponseEntity.notFound().build();
        else
            return ResponseEntity.ok(profesores);

    }

    @PostMapping
    public ResponseEntity<?> createProfesor(@RequestBody Profesor profesor) {
        if (profesorRepository.save(profesor) ==1)
            return ResponseEntity.status(HttpStatus.CREATED).body(profesor);
        else
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("No se pudo insertar el grupo.");
    }

    @GetMapping("/{id}")
    public ResponseEntity<?> getProfesorById(@PathVariable String id){
        Profesor profesor = profesorRepository.findById(id);
        if (profesor != null){
            return ResponseEntity.ok(profesor);
        }else{
            return ResponseEntity.notFound().build();
        }
    }

    @GetMapping("/{dni}")
    public ResponseEntity<?> getProfesorByDni(@PathVariable String dni){
        Profesor profesor = profesorRepository.findById(dni);
        if (profesor != null){
            return ResponseEntity.ok(profesor);
        }else{
            return ResponseEntity.notFound().build();
        }
    }

    @PutMapping("/{id}")
    public ResponseEntity<Profesor> updateCancion(@PathVariable String id, @RequestBody Profesor profesor) {
        Profesor existingProfesor = profesorRepository.findById(id);
        if (existingProfesor != null) {
            profesor.setIdprofesor(id);
            profesorRepository.update(profesor);
            return ResponseEntity.ok(profesor);

        }else{
            return ResponseEntity.notFound().build();
        }
    }



}
