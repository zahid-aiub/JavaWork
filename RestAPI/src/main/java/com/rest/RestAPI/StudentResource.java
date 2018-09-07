package com.rest.RestAPI;

import java.util.Arrays;
import java.util.List;

import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;

@Path("/students")
public class StudentResource {
	
	StudentDAO stDao = new StudentDAO();
	
	@GET
	@Produces({MediaType.APPLICATION_XML,MediaType.APPLICATION_JSON})
	public List<Student> getStudent() {
		System.out.println("Cal Student....!!");
		return stDao.getStudent();
	}
	
	@GET
	@Path("/student/{id}")
	@Produces({MediaType.APPLICATION_XML,MediaType.APPLICATION_JSON})
	public Student getStudent(@PathParam("id") int id) {
		return stDao.getStudent(id);
	}
	
	@POST
	@Path("/student")
	public Student createStudent(Student s1) {
		System.out.println(s1);
		stDao.create(s1);
		
		return s1;
	}

}
