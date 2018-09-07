package com.rest.RestAPI;

import javax.xml.bind.annotation.XmlRootElement;

import org.apache.taglibs.standard.extra.spath.Step;
import org.glassfish.internal.api.Private;

@XmlRootElement
public class Student {
	private String name;
	private int id;
	private String subject;
	private int mark;
	
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getSubject() {
		return subject;
	}
	public void setSubject(String subject) {
		this.subject = subject;
	}
	public int getMark() {
		return mark;
	}
	public void setMark(int mark) {
		this.mark = mark;
	}
	@Override
	public String toString() {
		return "Student [name=" + name + ", id=" + id + ", subject=" + subject + ", mark=" + mark + "]";
	}
	

}
