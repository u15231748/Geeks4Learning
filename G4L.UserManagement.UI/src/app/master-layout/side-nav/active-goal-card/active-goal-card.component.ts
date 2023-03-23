import { Component, OnInit } from '@angular/core';
import { ActiveGoalService } from 'src/app/goal-management/services/active-goal.service';
import { goalStatusStages } from './models/active-goal-model';

@Component({
  selector: 'app-active-goal-card',
  templateUrl: './active-goal-card.component.html',
  styleUrls: ['./active-goal-card.component.css']
})
export class ActiveGoalCardComponent implements OnInit {
  activeGoalStatus!: goalStatusStages
  remainingTime!: string

  constructor(private activeGoalPopupService: ActiveGoalService) { }

  ngOnInit(): void {
    this.activeGoalPopupService.getCountDownTimer()
      .subscribe((timeRemaining: string) => {
        this.remainingTime = timeRemaining;

        this.changeCardState(this.remainingTime.split(":"))
      })
  }

  changeCardState(timeparts: Array<string>): void {
    const [_h, minutes, _s] = timeparts

    if (+minutes < 1) this.activeGoalStatus = "danger"
    else if (+minutes < 5) this.activeGoalStatus = "warning"
    else this.activeGoalStatus = "good"
  }

  activeGoal() {
    return this.activeGoalPopupService.getActiveGoalObject();
  }

  getActiveGoalPopupState() {
    return this.activeGoalPopupService.getActiveGoalPopupWindowState();
  }

  viewGoal() {
    alert(this.activeGoal().title)
  }
}