package com.test.normal;

import java.io.FileOutputStream;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.Marshaller;

public class ObjectToXml {
	public static void main(String[] args) throws Exception {
		JAXBContext contextObj = JAXBContext.newInstance(Employee.class);

		Marshaller marshallerObj = contextObj.createMarshaller();
		marshallerObj.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);

		Employee emp1 = new Employee(1, "zahid", 50000,24);
		//Employee emp2 = new Employee(2, "shreya", 30000,22);
		
		marshallerObj.marshal(emp1, new FileOutputStream("employee.xml"));
		//marshallerObj.marshal(emp2, new FileOutputStream("employee.xml"));  //--->doing override 

	}
}