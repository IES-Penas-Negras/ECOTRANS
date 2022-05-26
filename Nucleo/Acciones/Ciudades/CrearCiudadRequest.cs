﻿using IESPeniasNegras.Ecotrans.Nucleo.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace IESPeniasNegras.Ecotrans.Nucleo.Acciones.Ciudades;

    public class CrearCiudadRequest
    {
        [Required]
        [StringLength(300)]
        public string NombreCiudad { get; set; }
        public int TipoObjetoId { get; set; }
        public int CP { get; set; }
        
    }

