package com.example.minireto.controller;

import com.example.minireto.model.Alumno;
import com.example.minireto.repository.Interfaces.AlumnoRepository;
import org.apache.coyote.Response;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Repository;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/alumnos")
public class AlumnoController {
    @Autowired
    private AlumnoRepository alumnoRepository;

    @GetMapping
    public ResponseEntity<?> getAllAlumnos() {
        List<Alumno> alumnos = alumnoRepository.findAll();
        if(alumnos.isEmpty()){
            return ResponseEntity.notFound().build();
        }else{
            return ResponseEntity.ok(alumnos);
        }
    }

    @PostMapping
    public String createAlumno(@RequestBody Alumno alumno) {
        int n = alumnoRepository.save(alumno);
        if(n == 1){
            return "Alumno agregado correctamente";

        }else {
            return "Alumno no agregado";
        }
    }

    @GetMapping("/{id}")
    public ResponseEntity<?> getAlumnoById(@PathVariable String id) {
        Alumno alumno = alumnoRepository.findById(id);
        if(alumno == null){
            return ResponseEntity.notFound().build();
        }else {
            return ResponseEntity.ok(alumno);
        }
    }

    @GetMapping("/{dni}")
    public ResponseEntity<?> getAlumnoByDni(@PathVariable String dni) {
        Alumno alumno = alumnoRepository.findByDni(dni);
        if(alumno == null){
            return ResponseEntity.notFound().build();
        }else {
            return ResponseEntity.ok(alumno);
        }
    }
    @PutMapping("/{id}")
    public ResponseEntity<?> updateAlumno(@PathVariable String id, @RequestBody Alumno alumno) {
        Alumno alumnoExiste = alumnoRepository.findById(id);
        if(alumnoExiste == null){
            return ResponseEntity.notFound().build();
        }else{
            alumno.setIdAlumno(id);
            alumnoRepository.update(alumno);
            return ResponseEntity.ok(alumnoExiste);
        }
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<?> deleteAlumno(@PathVariable String id) {
        Alumno alumno = alumnoRepository.findById(id);
        if(alumno == null){
            return ResponseEntity.notFound().build();
        }else{
            alumnoRepository.delete(id);
            return ResponseEntity.ok().build();
        }
    }


}
