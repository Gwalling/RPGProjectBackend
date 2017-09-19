﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SnoahRpg.Model;

namespace SnoahRpg.Controllers
{
    [Produces("application/json")]
    [Route("api/Monsters")]
    public class MonstersController : Controller
    {
        private readonly SnoahRpgContext _context;

        public MonstersController(SnoahRpgContext context)
        {
            _context = context;
<<<<<<< HEAD


        if (_context.Monster.Count() == 0)
            {
                Monster m1 = new Monster
                {
                Id = 1,
                Name = "Old Man",
                Health = 1,
                Image = "https://imgur.com/XckJ1D3",
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 100
                };

                Monster m2 = new Monster
                {
                Id = 2,
                Name = "Goblin",
                Image = "https://imgur.com/sRAyXbr",
                Health = 10,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 100
                };

                Monster m3 = new Monster
                {
                Id = 3,
                Name = "Wolf",
                Image = "https://imgur.com/tpkkwZ1",
                Health = 7,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 100
                };


                Monster m4 = new Monster
                {
                Id = 4,
                Name = "Bear",
                Image = "https://imgur.com/UyFNrWR",
                Health = 15,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 100
                };

                Monster m5 = new Monster
                {
                Id = 5,
                Name = "Orc",
                Image = "https://imgur.com/Tev7Nl4",
                Health = 25,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 400
                };

                Monster m6 = new Monster
                {
                Id = 6,
                Name = "Evil Knight",
                Image = "https://imgur.com/J5z0EyT",
                Health = 30,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 300
                };



                Monster m7 = new Monster
                {
                Id = 7,
                Name = "Sand Worm",
                Image = "https://imgur.com/xYF31OU",
                Health = 40,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 1000
                };

                Monster m8 = new Monster
                {
                Id = 8,
                Name = "Sand Yeti",
                Image = "https://imgur.com/uQN0XUb",
                Health = 40,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 400
                };

                Monster m9 = new Monster
                {
                Id = 9,
                Name = "Cactus Patch Kid",
                Image = "https://imgur.com/9aGsDrg",
                Health = 100,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 400
                };

                Monster m10 = new Monster
                {
                Id = 10,
                Name = "Muad'Dib",
                Image = "https://imgur.com/T5N8cMz",
                Health = 200,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 10000
                };

                Monster m11 = new Monster
                {
                Id = 11,
                Name = "Rock Golem",
                Image = "https://imgur.com/RiFdN89",
                Health = 70,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 300
                };



                Monster m12 = new Monster
                {
                Id = 12,
                Name = "Giant Snake",
                Image = "https://imgur.com/kcfIli1",
                Health = 100,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 200
                };


                Monster m13 = new Monster
                {
                Id = 13,
                Name = "Frost Giant",
                Image = "https://imgur.com/eeput4H",
                Health = 120,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 600
                };





                Monster m14 = new Monster
                {
                Id = 14,
                Name = "Mummy",
                Image = "https://imgur.com/aknDbaZ",
                Health = 100,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 1000
                };


                Monster m15 = new Monster
                {
                Id = 15,
                Name = "Frost Troll",
                Image = "https://imgur.com/vQcsxLs",
                Health = 150,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 300
                };





                Monster m16 = new Monster
                {
                Id = 16,
                Name = "Frozen Banshee",
                Image = "https://imgur.com/Ul4eZaX",
                Health = 130,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 0
                };



                Monster m16 = new Monster
                {
                Id = 16,
                Name = "Vicious Cloud Dog",
                Image = "https://imgur.com/Bi0dWXQ",
                Health = 1,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 5
                };



                Monster m17 = new Monster
                {
                Id = 17,
                Name = "Toxic Cloud",
                Image = "https://imgur.com/huGLhY7",
                Health = 15,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 4
                };




                Monster m18 = new Monster
                {
                Id = 18,
                Name = "Volcanic Imp",
                Image = "https://imgur.com/bFBJRzb",
                Health = 300,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 200
                };



                Monster m19 = new Monster
                {
                Id = 12,
                Name = "Magma Snake",
                Image = "https://imgur.com/UzcwhLQ",
                Health = 350,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 400
                };





                Monster m20 = new Monster
                {
                Id = 20,
                Name = "Lava Dragon",
                Image = "https://imgur.com/zLvtkZy",
                Health = 400,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 500
                };




                Monster m21 = new Monster
                {
                Id = 21,
                Name = "King of Redwood Castle",
                Image = "https://imgur.com/UZzfaj2",
                Health = 400,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 99999
                };


                Monster m22 = new Monster
                {
                Id = 22,
                Name = "Harrison True King of Redwood",
                Image = "https://imgur.com/boRTdBN",
                Health = 999,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 9999999
                };


                Monster m23 = new Monster
                {
                Id = 23,
                Name = "Dark Magician",
                Image = "https://imgur.com/zNpB0Fx",
                Health = 250,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 10
                };


                Monster m24 = new Monster
                {
                Id = 24,
                Name = "Tortured Soul",
                Image = "https://imgur.com/Mze53Or",
                Health = 300,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 0
                };


                Monster m25 = new Monster
                {
                Id = 25,
                Name = "Evil Hotdog",
                Image = "https://imgur.com/5som72N",
                Health = 1,
                CurrentChest = null,
                CurrentHelm = null,
                CurrentWrist = null,
                CurrentWeapon = null,
                Gold = 1
                };




            };
        }
    }



        // GET: api/Monsters
        [HttpGet]
        public IEnumerable<Monster> GetMonster()
        {
            return _context.Monster;
        }

        // GET: api/Monsters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMonster([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var monster = await _context.Monster.SingleOrDefaultAsync(m => m.Id == id);

            if (monster == null)
            {
                return NotFound();
            }

            return Ok(monster);
        }

        // PUT: api/Monsters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonster([FromRoute] int id, [FromBody] Monster monster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != monster.Id)
            {
                return BadRequest();
            }

            _context.Entry(monster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Monsters
        [HttpPost]
        public async Task<IActionResult> PostMonster([FromBody] Monster monster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Monster.Add(monster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonster", new { id = monster.Id }, monster);
        }

        // DELETE: api/Monsters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMonster([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var monster = await _context.Monster.SingleOrDefaultAsync(m => m.Id == id);
            if (monster == null)
            {
                return NotFound();
            }

            _context.Monster.Remove(monster);
            await _context.SaveChangesAsync();

            return Ok(monster);
        }

        private bool MonsterExists(int id)
        {
            return _context.Monster.Any(e => e.Id == id);
        }
    }
}