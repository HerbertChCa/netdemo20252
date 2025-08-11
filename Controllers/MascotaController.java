@Controller
public class MascotaController {

    @GetMapping("/registro")
    public String mostrarFormulario(Model model) {
        model.addAttribute("mascota", new Mascota());
        return "registro";
    }

    @PostMapping("/registro")
    public String registrarMascota(@ModelAttribute Mascota mascota) {
        // guardar en BD o lista temporal
        return "registro-exitoso";
    }
}
