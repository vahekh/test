import { Component, OnInit } from '@angular/core';

import { Hero } from '../hero';
import { HeroService } from '../hero.service';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  heroes: Hero[];

  constructor(private heroService: HeroService) { }

  ngOnInit() {
    this.getHeroes();
  }

  getHeroes(): void {
    this.heroService.getHeroes()
      .subscribe(heroes => this.heroes = heroes);
  }

  //onKey(event: any) { 
  //  this.values += event.target.value + ' | ';
  //}
  addHero(newHero: string) {
    if (newHero) {
      let hero1 = new Hero();
      hero1.name = newHero;
      this.heroes.push(hero1);
    }
  }
}
