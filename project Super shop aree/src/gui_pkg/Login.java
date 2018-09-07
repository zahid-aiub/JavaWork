package gui_pkg;

import java.awt.Component;
import java.awt.Container;

import javax.swing.*;

public class Login{
	String userType;
	HomePage hrefer;
	String userId;
	String pass;
	String name;
	
	public Login(String userId,String password,HomePage href){
		this.hrefer=href;
		
		//if check of login verfied then goto customer gui for customer
		//user id diye query kore usertype anbe thn search dbe
		//check gulo ArrayList r moddhe hbe
		
		this.pass=password;
		this.userId=userId;
		this.userType="customer";
		
		String databaseCusID="15";
		String databaseCusPassword="92";
		String databaseAdmID="16";
		String databaseAdmPassword="93";
		
if((this.userId.equals(databaseCusID) && this.pass.equals(databaseCusPassword)) ||( this.userId.equals(databaseAdmID) && this.pass.equals(databaseAdmPassword))){
	             
	hrefer.j.setVisible(false);
	this.gotoUser();
	
		}
		else{
			
			hrefer.adderror();
		}
		
		
	}
	
	public void gotoUser(){
		String cus="customer";
		String admn="admin";
		
		if(this.userType.equals(cus)){
			//database theke c_name ber korbe then{{{ this.name=c_name
			this.name="Alavi";
			new Customer_gui(this.userId,this.name,this.pass);
		}
		else if(this.userType.equals(admn)){
			//database theke u_name ber korbe then{{{ this.name=u_name
			this.name="Ovi";
			new Admin_gui(this.userId,this.name,this.pass);
		}
		else{
	
			hrefer.adderror();
		}
		
	}
	

}
