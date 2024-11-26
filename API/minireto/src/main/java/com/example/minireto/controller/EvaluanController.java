package com.example.minireto.controller;

import com.example.minireto.model.Evaluan;
import com.example.minireto.model.Realizan;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/evaluan")
public class EvaluanController {

    @Autowired
    private com.example.minireto.repository.interfaces.EvaluanRepository evaluanRepository;

    @GetMapping
    public ResponseEntity<?> getAllEvaluan() {
        List<Evaluan> evaluan = evaluanRepository.findAll();
        if(evaluan.isEmpty()){
            return ResponseEntity.notFound().build();
        }else{
            return ResponseEntity.ok(evaluan);
        }
    }

    @PostMapping
    public ResponseEntity<?> createEvaluan(@RequestBody Evaluan evaluan) {
        if (evaluanRepository.save(evaluan) ==1)
            return ResponseEntity.status(HttpStatus.CREATED).body(evaluan);
        else
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("No se pudo insertar.");
    }

    @GetMapping("/{id}")
    public ResponseEntity<?> getEvaluanById(@PathVariable int id) {
        Evaluan evaluan = evaluanRepository.findById(id);
        if(evaluan == null){
            return ResponseEntity.notFound().build();
        }else {
            return ResponseEntity.ok(evaluan);
        }
    }

    @PutMapping("/{id}")
    public ResponseEntity<?> updateEvaluan(@PathVariable int id, @RequestBody Evaluan evaluan) {
        Evaluan evaluanExiste = evaluanRepository.findById(id);
        if(evaluanExiste == null){
            return ResponseEntity.notFound().build();
        }else{
            evaluan.setId(id);
            evaluanRepository.update(evaluan);
            return ResponseEntity.ok(evaluanExiste);
        }
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<?> deleteEvaluan(@PathVariable int id) {
        Evaluan evaluan = evaluanRepository.findById(id);
        if (evaluan == null) {
            return ResponseEntity.notFound().build();
        } else {
            evaluanRepository.deleteById(id);
            return ResponseEntity.ok().build();
        }
    }

}
