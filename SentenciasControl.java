public class SentenciasControl {

    // Método que determina si un número es positivo, negativo o cero
    public void verificarNumero(int numero) {
        if (numero > 0) {
            System.out.println("El número es positivo.");
        } else if (numero < 0) {
            System.out.println("El número es negativo.");
        } else {
            System.out.println("El número es cero.");
        }
    }

    // Método que determina si una persona es mayor de edad
    public void esMayorDeEdad(int edad) {
        if (edad >= 18) {
            System.out.println("Es mayor de edad.");
        } else {
            System.out.println("Es menor de edad.");
        }
    }

    // Método que verifica si un número está en un rango específico
    public void estaEnRango(int numero, int limiteInferior, int limiteSuperior) {
        if (numero >= limiteInferior && numero <= limiteSuperior) {
            System.out.println("El número está dentro del rango.");
        } else {
            System.out.println("El número está fuera del rango.");
        }
    }

    // Método que determina si una persona cumple ciertas condiciones
    public void verificarCondiciones(int edad, boolean tieneLicencia, boolean haTomadoAlcohol) {
        if (edad >= 18 && tieneLicencia && !haTomadoAlcohol) {
            System.out.println("La persona puede conducir.");
        } else {
            System.out.println("La persona no puede conducir.");
        }
    }

    // Método que evalúa si se cumple al menos una de dos condiciones
    public void cumpleAlgunaCondicion(boolean condicion1, boolean condicion2) {
        if (condicion1 || condicion2) {
            System.out.println("Se cumple al menos una condición.");
        } else {
            System.out.println("No se cumple ninguna condición.");
        }
    }

    public static void main(String[] args) {
        SentenciasControl control = new SentenciasControl();

        // Ejemplos de uso de los métodos
        control.verificarNumero(10);
        control.esMayorDeEdad(17);
        control.estaEnRango(5, 1, 10);
        control.verificarCondiciones(20, true, false);
        control.cumpleAlgunaCondicion(false, true);
    }
}
