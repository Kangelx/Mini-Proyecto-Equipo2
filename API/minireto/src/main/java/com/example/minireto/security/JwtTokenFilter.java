package com.example.minireto.security;

import io.jsonwebtoken.Claims;
import io.jsonwebtoken.Jws;
import io.jsonwebtoken.JwtException;
import io.jsonwebtoken.Jwts;
import io.jsonwebtoken.security.Keys;
import jakarta.servlet.FilterChain;
import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.core.userdetails.User;
import org.springframework.web.filter.OncePerRequestFilter;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import java.io.IOException;
import java.security.Key;
import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;

public class JwtTokenFilter extends OncePerRequestFilter {
    private final String secretKey = "ahadeguerraisotermavolatilcharcobarcocabezaapiverdeazulrojanegraverdeabuelomiguelhindurainunicornioaccesoadatossistemasdegestionempresarial";
    private static final Logger log = LoggerFactory.getLogger(JwtTokenFilter.class);

    @Override
    protected void doFilterInternal(HttpServletRequest request, HttpServletResponse response, FilterChain filterChain)
            throws ServletException, IOException {
        String token = request.getHeader("Authorization");

        if (token != null && token.startsWith("Bearer ")) {
            token = token.substring(7); // Eliminar "Bearer "
            log.debug("Procesando token JWT: {}", token);

            try {
                Key key = Keys.hmacShaKeyFor(secretKey.getBytes());
                Jws<Claims> claimsJws = Jwts.parserBuilder().setSigningKey(key).build().parseClaimsJws(token);
                Claims claims = claimsJws.getBody();

                // Extraer información del token
                String username = claims.getSubject();
                log.debug("Username extraído del token JWT: {}", username);

                if (username != null && SecurityContextHolder.getContext().getAuthentication() == null) {
                    // Crear una autenticación para Spring Security
                    UsernamePasswordAuthenticationToken authenticationToken =
                            new UsernamePasswordAuthenticationToken(username, null, Collections.emptyList());
                    SecurityContextHolder.getContext().setAuthentication(authenticationToken);
                }

            } catch (JwtException e) {
                log.error("Error al procesar el token JWT: {}", e.getMessage());
                SecurityContextHolder.clearContext();
            }
        } else {
            log.debug("No se encontró token de autenticación en la solicitud.");
        }

        // Continuar con la cadena de filtros
        filterChain.doFilter(request, response);
    }
}
