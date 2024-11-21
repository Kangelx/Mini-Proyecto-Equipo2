package com.example.minireto;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.autoconfigure.jdbc.DataSourceAutoConfiguration;

@SpringBootApplication(exclude = {DataSourceAutoConfiguration.class })
public class MiniretoApplication {

	public static void main(String[] args) {
		SpringApplication.run(MiniretoApplication.class, args);

		

	}

}
