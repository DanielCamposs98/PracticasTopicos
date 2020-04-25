package ManejadoresEventos;

import Paneles.ModificaEmpleado;
import Paneles.EmpleadoPanel;
import Paneles.DiasPanel;
import Paneles.DepartamentoPanel;
import Tablas.NominaConsulta;
import Colecciones.HashTEmpleado;
import Tablas.ImprimirEmpleados;
import Paneles.BonoExtraPanel;
import Colecciones.ArrayLNomina;
import Colecciones.ArrayLDepartamentos;
import Colecciones.ArrayLDias;
import FramePrincipal.MenuPrincipal;
import Paneles.EliminarEmpleado;
import Paneles.ReporteEmpDepto;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import Tablas.ConsultaDpto;
import Tablas.ConsultaEncDpto;
import Tablas.BonosConsulta;
import Tablas.DiasConsulta;

import javax.swing.JOptionPane;

public class MenuEventos implements ActionListener {

    private MenuPrincipal menuPri;
    private HashTEmpleado tablaEmpleados;
    private ArrayLDepartamentos arrDeptos;
    private ArrayLNomina arrNom;
    private ArrayLDias arrDias;

    public MenuEventos(MenuPrincipal mp, ArrayLDias arrDias, HashTEmpleado tablaEmpleados, ArrayLDepartamentos arrDeptos, ArrayLNomina arr) {
        menuPri = mp;
        this.tablaEmpleados = tablaEmpleados;
        this.arrDeptos = arrDeptos;
        this.arrNom = arr;
        this.arrDias = arrDias;
    }

    public void actionPerformed(ActionEvent e) {

        if (e.getSource() == menuPri.getItmRegEmp()) {
            if (arrDeptos.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay Departamentos añadidos.", "AVISO", JOptionPane.ERROR_MESSAGE);
            } else {
                EmpleadoPanel empleadoPanel = new EmpleadoPanel(menuPri, tablaEmpleados, arrDeptos);
            }
        }

        if (e.getSource() == menuPri.getItmRegDepto()) {
            DepartamentoPanel departamentoPanel = new DepartamentoPanel(menuPri, arrDeptos);
        }

        if (e.getSource() == menuPri.getItmRegBono()) {
            if (tablaEmpleados.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay empleados añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
            } else {
                BonoExtraPanel bonoExtraPanel = new BonoExtraPanel(menuPri, tablaEmpleados);
            }
        }

        if (e.getSource() == menuPri.getItmConsultaDias()) {
            if (tablaEmpleados.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay empleados registrados.", "Error", JOptionPane.ERROR_MESSAGE);
            } else {
                DiasConsulta dc = new DiasConsulta(menuPri, arrDias);
            }
        }

        if (e.getSource() == menuPri.getItmAcercaDe()) {
            String nombre = "Topicos Avanzados de Programación    "
                    + "→ Proyecto Nómina ←\n"
                    + "   Integrantes: \n"
                    + "   → Campos Medina Francisco Daniel \n"
                    + "   → Manjarrez Chaparro Alma Sayed \n"
                    + "   → Pacheco García Miguel Antonio ";
            JOptionPane.showMessageDialog(null, nombre, "Acerca de", JOptionPane.INFORMATION_MESSAGE);
        }

        if (e.getSource() == menuPri.getItmCalNomina()) {
            if (tablaEmpleados.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay empledos añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
            } else {
                NominaConsulta nominaConsulta = new NominaConsulta(menuPri, arrNom, tablaEmpleados);
            }
        }

        if (e.getSource() == menuPri.getItmReinNomina()) {
            int dialog = JOptionPane.showConfirmDialog(null, "Deseas borrar la nomina?", "Aviso", JOptionPane.YES_NO_OPTION);
            if (dialog == JOptionPane.YES_OPTION) {
                arrNom.borraNomina();
                arrDias.borraDias();
                tablaEmpleados.reiniciaBonos();
            }
        }

        if (e.getSource() == menuPri.getItmRepEmpDepto()) {
            if (arrDeptos.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay departamentos añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
            } else {
                ReporteEmpDepto reporteEmpDepto = new ReporteEmpDepto(menuPri, tablaEmpleados, arrDeptos);
            }
        }

        if (e.getSource() == menuPri.getItmRegDias()) {
            if (tablaEmpleados.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay empleados añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
            } else {
                DiasPanel diasPanel = new DiasPanel(menuPri, arrDias, tablaEmpleados);
            }
        }

        if (e.getSource() == menuPri.getItmImpDepto()) {
            if (arrDeptos.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay departamentos añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
            } else if (tablaEmpleados.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay empleados añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
            } else {
                ImprimirEmpleados imprimirEmpleados = new ImprimirEmpleados(menuPri, tablaEmpleados);
            }
        }

        if (e.getSource() == menuPri.getItmBorrarEmp()) {
            if (tablaEmpleados.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay empleados añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
            } else {
                EliminarEmpleado eliminarEmpleado = new EliminarEmpleado(menuPri, tablaEmpleados, arrDeptos, arrDias);
            }
        }

        if (e.getSource() == menuPri.getItmConsultaDpto()) {
            if (arrDeptos.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay departamentos añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
            } else {
                ConsultaDpto dpe = new ConsultaDpto(menuPri, arrDeptos);
            }
        }
        
        if (e.getSource() == menuPri.getItmConEncDpto()) {
            if (arrDeptos.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay departamentos añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
            } else {
                if (arrDeptos.contieneEncargados() == true) {
                    ConsultaEncDpto dpe = new ConsultaEncDpto(menuPri, arrDeptos);
                } else {
                    JOptionPane.showMessageDialog(null, "No hay encargados asignados.", "Error", JOptionPane.ERROR_MESSAGE);
                }
            }
        }
        
        if (e.getSource() == menuPri.getItmConsultaBonos()) {
            if (tablaEmpleados.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay empleados añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
            } else {
                BonosConsulta bn = new BonosConsulta(menuPri, tablaEmpleados);
            }
        }

        if (e.getSource() == menuPri.getItmModificaEmp()) {
            if (tablaEmpleados.vacia()) {
                JOptionPane.showMessageDialog(null, "No hay empleados añadidos.", "Error", JOptionPane.ERROR_MESSAGE);
            } else {
                ModificaEmpleado me = new ModificaEmpleado(menuPri, tablaEmpleados, arrDias);
            }

        }
    }
}
