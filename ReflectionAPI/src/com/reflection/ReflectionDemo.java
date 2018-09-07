package com.reflection;

import java.lang.reflect.Method;

import com.test.Test;

public class ReflectionDemo {

	public static void main(String[] args) throws Exception{
		
		Class c = Class.forName("com.test.Test");
		Test t = (Test) c.newInstance();
		
		Method m = c.getDeclaredMethod("show", null);
		m.setAccessible(true);
		m.invoke(t, null);
	}

}
