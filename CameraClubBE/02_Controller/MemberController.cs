using CameraClubBE;
using CameraClubBE.Service;
using CameraClubBE.Model;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Serilog;

namespace CameraClubBE.Controller

    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;
        public MemberController(IMemberService memberServiceFromBuilder)
        {
            _memberService = memberServiceFromBuilder;
        }
        [HttpPost("Member/SignIn")]
        public async Task<ActionResult<PMember>> SignInMember(SignIn signIn)
        {
            if (!await _memberService.MemberExistsAsync(signIn.email))
            {
                return NotFound("Incorrect email or password");
            }

            try
            {
                Member signInAttempt = await _memberServices.GetMemberByEmailAsync(signIn.email);
                Console.WriteLine(signInAttempt.FirstName);
                if (await _memberServices.VerifyPassword(signIn.rawPassword, signInAttempt))
                {
                    PMember signedInMember = new PMember(signInAttempt);
                    Log.Information("User signed in");
                    return Ok(signedInMember);
                }
                else
                    return NotFound("Incorrect email or password; password does not match");
            }
            catch (Exception e)
            {
                return NotFound("Incorrect email or password; password does not match");
            }
        }
    }