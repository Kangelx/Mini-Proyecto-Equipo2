package com.example.minireto.controller;

import com.example.minireto.model.Profesor;
import com.example.minireto.model.Proyecto;
import com.example.minireto.repository.interfaces.ProfesorRepository;
import com.example.minireto.repository.interfaces.ProyectoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;


    @RestController
    @RequestMapping("/proyecto")
    public class ProyectoController {

        @Autowired
        private ProyectoRepository proyectoRepository;

        @GetMapping()
        public ResponseEntity<?> getAllProyectos(){
            List<Proyecto> profesores = proyectoRepository.findAll();
            if (profesores.isEmpty())
                return ResponseEntity.notFound().build();
            else
                return ResponseEntity.ok(profesores);

        }

        @PostMapping
        public ResponseEntity<?> createProyecto(@RequestBody Proyecto proyecto) {
            if (proyectoRepository.save(proyecto) ==1)
                return ResponseEntity.status(HttpStatus.CREATED).body(proyecto);
            else
                return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("No se pudo insertar el grupo.");
        }

        @GetMapping("/{id}")
        public ResponseEntity<?> getProyectoById(@PathVariable int id){
            Proyecto proyecto = proyectoRepository.findById(id);
            if (proyecto != null){
                return ResponseEntity.ok(proyecto);
            }else{
                return ResponseEntity.notFound().build();
            }
        }

        @PutMapping("/{id}")
        public ResponseEntity<Proyecto> updateProyecto(@PathVariable int id, @RequestBody Proyecto proyecto) {
            Proyecto existingProyecto = proyectoRepository.findById(id);
            if (existingProyecto != null) {
                proyecto.setIdproyecto(id);
                proyectoRepository.update(proyecto);
                return ResponseEntity.ok(proyecto);

            }else{
                return ResponseEntity.notFound().build();
            }
        }

        @DeleteMapping("/{id}")
        public ResponseEntity<?> deleteAlumno(@PathVariable int id) {
            Proyecto alumno = proyectoRepository.findById(id);
            if(alumno == null){
                return ResponseEntity.notFound().build();
            }else{
                proyectoRepository.deleteById(id);
                return ResponseEntity.ok().build();
            }
        }



    }

