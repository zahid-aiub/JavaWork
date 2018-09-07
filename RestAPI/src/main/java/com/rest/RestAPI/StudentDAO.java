package com.rest.RestAPI;

import java.util.ArrayList;
import java.util.List;

public class StudentDAO {
	List<Student> students;
	
	public StudentDAO() {
		students = new ArrayList<Student>();
		
		Student a1 = new Student();
		a1.setName("Zahid");
		a1.setId(101);
		a1.setSubject("Java");
		a1.setMark(88);
		
		Student a2 = new Student();
		a2.setName("Noman");
		a2.setId(102);
		a2.setSubject("Python");
		a2.setMark(95);
		
		Student a3 = new Student();
		a3.setName("Shreya");
		a3.setId(103);
		a3.setSubject("C#");
		a3.setMark(86);
		
		students.add(a1);
		students.add(a2);
		students.add(a3);
	}
	
	public List<Student> getStudent(){
		
		return students;
	}
	
	public Student getStudent(int id) {
		
		for(Student s : students) {
			if (s.getId()==id) {
				return s;
			}
		}
		return null;
	}

	public void create(Student s1) {
		students.add(s1);
		
	}
	
}
