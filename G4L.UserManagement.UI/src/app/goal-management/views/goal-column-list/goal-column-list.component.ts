import { Component, Input, OnInit } from '@angular/core';
import { GoalModel, goalTypes } from '../../models/goal-model';

@Component({
  selector: 'app-goal-column-list',
  templateUrl: './goal-column-list.component.html',
  styleUrls: ['./goal-column-list.component.css']
})
export class GoalColumnListComponent implements OnInit {

  @Input()
  goalsList!: Array<GoalModel>

  @Input()
  connectedIDList!: Array<string>

  @Input()
  onDropRef!: any

  @Input()
  onViewGoalRef!: any

  @Input()
  listID!: goalTypes

  constructor() { }

  ngOnInit(): void { }

}
