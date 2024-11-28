package com.example.minireto.security;

import com.example.minireto.model.Profesor;
import com.example.minireto.repository.ProfesorRepositoryImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

@Service
public class CustomUserDetailsService implements UserDetailsService {
    @Autowired
    private ProfesorRepositoryImpl profesorRepository;

    @Override
    public UserDetails loadUserByUsername(String dni) throws UsernameNotFoundException {
        // Buscar usuario en la base de datos
        Profesor profesor = profesorRepository.findByDni(dni);
        if (profesor == null){
            throw new UsernameNotFoundException("Usuario no encontrado: " + dni);
        }

        // Convertirlo a un objeto UserDetails
        return org.springframework.security.core.userdetails.User.builder()
                .username(profesor.getDni())
                .password(profesor.getPassword_encr()) // Contraseña encriptada
                .build();
    }
}
