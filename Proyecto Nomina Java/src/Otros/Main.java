package Otros;

import FramePrincipal.MenuPrincipal;
import javax.swing.JFrame;
public class Main {

    public static void main(String[] a) {
        MenuPrincipal menu = new MenuPrincipal();
        menu.setSize(400, 200);
        menu.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        menu.setVisible(true);
        menu.setLocationRelativeTo(null);
        menu.setResizable(false);
    }
}
