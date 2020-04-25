package FramePrincipal;

import ManejadoresEventos.MenuEventos;
import Colecciones.HashTEmpleado;
import Colecciones.ArrayLNomina;
import Colecciones.ArrayLDepartamentos;
import Colecciones.ArrayLDias;
import UIManagerP.U;
import java.awt.BorderLayout;
import java.awt.Color;
import javax.swing.Icon;
import javax.swing.ImageIcon;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.UIManager;

public class MenuPrincipal extends JFrame {

    private HashTEmpleado tablaEmpleados;
    private ArrayLDepartamentos arrDeptos;
    private ArrayLNomina arrayNomina;
    private ArrayLDias arrDias;
    private JMenuBar barra;
    private JMenu menuRegistrar, menuNomina, menuReportes, menuConsulta, menuAyuda;
    private JMenuItem itmRegEmp, itmRegDepto, itmRegDias, itmRegBono, itmCalNomina, itmReNomina, itmBorrarEmp,
            itmAcercaDe, itmRepEmpDepto, itmImpDepto, itmConsultaDpto, itmConEncDpto, itmConsultaDias, itmConsultaBonos, itmModificaEmp;

    public MenuPrincipal() {
        super("Nomina App v.1.0");
        UIManager ui = new U();
        getContentPane().setBackground(Color.darkGray);
        tablaEmpleados = new HashTEmpleado();
        arrDeptos = new ArrayLDepartamentos();
        arrDias = new ArrayLDias(tablaEmpleados);
        arrayNomina = new ArrayLNomina(arrDias, tablaEmpleados);
        MenuEventos mEventos = new MenuEventos(this, arrDias, tablaEmpleados, arrDeptos, arrayNomina);

        barra = new JMenuBar();
        menuRegistrar = new JMenu("Registro");
        menuNomina = new JMenu("Nómina");
        menuReportes = new JMenu("Reportes");
        menuAyuda = new JMenu("Ayuda");

        itmRegEmp = new JMenuItem("Registrar Empleado");
        menuRegistrar.add(itmRegEmp);
        itmRegDepto = new JMenuItem("Registrar Departamento");
        menuRegistrar.add(itmRegDepto);
        itmRegDias = new JMenuItem("Capturar Días Laborados");
        menuRegistrar.add(itmRegDias);
        itmRegBono = new JMenuItem("Agregar Bono Extra");
        menuRegistrar.add(itmRegBono);
        itmModificaEmp = new JMenuItem("Añade datos a Empleado");
        menuRegistrar.add(itmModificaEmp);

        itmCalNomina = new JMenuItem("Calcular Nómina");
        menuNomina.add(itmCalNomina);
        itmReNomina = new JMenuItem("Reiniciar Nómina");
        menuNomina.add(itmReNomina);
        itmBorrarEmp = new JMenuItem("Borrar Empleado");
        menuNomina.add(itmBorrarEmp);

        itmRepEmpDepto = new JMenuItem("Reporte de Empleado por Depto");
        menuReportes.add(itmRepEmpDepto);
        itmImpDepto = new JMenuItem("Imprimir Empleados");
        menuReportes.add(itmImpDepto);

        menuConsulta = new JMenu("Consultas");
        itmConsultaDpto = new JMenuItem("Consulta por Departamento");
        menuConsulta.add(itmConsultaDpto);
        itmConEncDpto = new JMenuItem("Encargado por Departamento");
        menuConsulta.add(itmConEncDpto);
        itmConsultaDias = new JMenuItem("Consulta Dias Laborados");
        menuConsulta.add(itmConsultaDias);
        itmConsultaBonos = new JMenuItem("Consulta Bonos Extra");
        menuConsulta.add(itmConsultaBonos);

        itmAcercaDe = new JMenuItem("Acerca de");
        menuAyuda.add(itmAcercaDe);

        itmAcercaDe.addActionListener(mEventos);
        itmRegBono.addActionListener(mEventos);
        itmRegDepto.addActionListener(mEventos);
        itmModificaEmp.addActionListener(mEventos);
        itmCalNomina.addActionListener(mEventos);
        itmRegEmp.addActionListener(mEventos);
        itmReNomina.addActionListener(mEventos);
        itmRepEmpDepto.addActionListener(mEventos);
        itmRegDias.addActionListener(mEventos);
        itmImpDepto.addActionListener(mEventos);
        itmBorrarEmp.addActionListener(mEventos);
        itmConsultaDpto.addActionListener(mEventos);
        itmConEncDpto.addActionListener(mEventos);
        itmConsultaDias.addActionListener(mEventos);
        itmConsultaBonos.addActionListener(mEventos);

        barra.add(menuRegistrar);
        barra.add(menuNomina);
        barra.add(menuReportes);
        barra.add(menuConsulta);
        barra.add(menuAyuda);

        JLabel lblIcono = new JLabel("");
        Icon im = new ImageIcon(getClass().getResource("iconoPrin.png"));
        lblIcono.setIcon(im);

        add(new JLabel("                                                 "), BorderLayout.WEST);
        add(new JLabel("                                             "), BorderLayout.EAST);
        add(lblIcono, BorderLayout.CENTER);
        add(barra, BorderLayout.NORTH);

    }

    public JMenuItem getItmModificaEmp() {
        return itmModificaEmp;
    }

    public JMenuItem getItmReNomina() {
        return itmReNomina;
    }

    public JMenuItem getItmConsultaDias() {
        return itmConsultaDias;
    }

    public HashTEmpleado getTablaEmpleados() {
        return tablaEmpleados;
    }

    public ArrayLDias getArrDias() {
        return arrDias;
    }

    public JMenuBar getBarra() {
        return barra;
    }

    public JMenu getMenuRegistrar() {
        return menuRegistrar;
    }

    public JMenu getMenuNomina() {
        return menuNomina;
    }

    public JMenu getMenuReportes() {
        return menuReportes;
    }

    public JMenu getMenuAyuda() {
        return menuAyuda;
    }

    public JMenuItem getItmRegEmp() {
        return itmRegEmp;
    }

    public JMenuItem getItmRegDepto() {
        return itmRegDepto;
    }

    public JMenuItem getItmRegDias() {
        return itmRegDias;
    }

    public JMenuItem getItmConsultaBonos() {
        return itmConsultaBonos;
    }

    public JMenuItem getItmRegBono() {
        return itmRegBono;
    }

    public JMenuItem getItmCalNomina() {
        return itmCalNomina;
    }

    public JMenuItem getItmReinNomina() {
        return itmReNomina;
    }

    public JMenuItem getItmBorrarEmp() {
        return itmBorrarEmp;
    }

    public JMenuItem getItmAcercaDe() {
        return itmAcercaDe;
    }

    public JMenuItem getItmRepEmpDepto() {
        return itmRepEmpDepto;
    }

    public JMenuItem getItmImpDepto() {
        return itmImpDepto;
    }

    public ArrayLDepartamentos getArrDeptos() {
        return arrDeptos;
    }

    public ArrayLNomina getArrayNomina() {
        return arrayNomina;
    }

    public JMenu getMenuConsulta() {
        return menuConsulta;
    }

    public JMenuItem getItmConsultaDpto() {
        return itmConsultaDpto;
    }

    public JMenuItem getItmConEncDpto() {
        return itmConEncDpto;
    }

}
