package com.wx.main;

import java.util.Scanner;

public class Main {
	private final static int cz = 8 * 60;
	private final static int dz = 24 * 60;
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int rs = scan.nextInt();
		scan.close();
		int h = rs / 100;
		int m = rs - h * 100;
		if(h < 8){
			int sumM = h * 60 + m;
			int c = sumM - cz;
			int sjm = dz + c;
			h = sjm / 60;
			m = sjm % 60;
		}else{
			h -= 8;
		}
		System.out.println(h * 100 + m);
	}

}
