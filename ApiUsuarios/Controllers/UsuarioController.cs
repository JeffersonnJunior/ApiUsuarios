﻿using ApiUsuarios.Data.Dtos;
using ApiUsuarios.Models;
using ApiUsuarios.Service;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ApiUsuarios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService cadastroService)
        {
            _usuarioService = cadastroService;
        }

        [HttpPost("Cadastro")]
        public async Task <IActionResult> CadastraUsuario(CreateUsuarioDto dto)
        {
            await _usuarioService.Cadastra(dto);
            return Ok("Usuário cadastrado!");
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
           var token = await _usuarioService.Login(dto);
            return Ok(token);
        }

    }
}
