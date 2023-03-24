import { Component, Input } from '@angular/core';
import { MdbModalRef, MdbModalService } from 'mdb-angular-ui-kit/modal';
import { ViewSelectedGoalComponent } from '../../modals/views/view-selected-goal/view-selected-goal.component';
import { GoalModel } from '../../models/goal-model';

@Component({
  selector: 'app-goal-card',
  templateUrl: './goal-card.component.html',
  styleUrls: ['./goal-card.component.css'],
})
export class GoalCardComponent {
  @Input()
  goalId!: number | undefined;

  @Input()
  goalTitle!: string;

  @Input()
  goalDescription!: string;

  @Input()
  goalDuration!: string;

  @Input()
  goalState!: 'backlog' | 'started' | 'paused' | 'completed' | 'archived';

  @Input()
  goal!: GoalModel;

  @Input()
  onViewGoalRef!: any;

  modalRef: MdbModalRef<ViewSelectedGoalComponent> | null = null;

  constructor(private modalService: MdbModalService) {}

  grab(event: any) {
    const { target } = event;
    target.style.cursor = 'grabbing';
  }

  release(event: any) {
    const { target } = event;
    target.style.cursor = 'grab';
  }

  onViewGoal(goal?: GoalModel): void {
    this.modalRef = this.modalService.open(ViewSelectedGoalComponent, {
      data: { goal: goal },
      containerClass: 'modal top fade modal-backdrop',
      ignoreBackdropClick: false,
      modalClass: 'modal-xl modal-dialog-centered',
    });
  }

  onCloseGoal(): void {
    if (this.modalRef) {
      this.modalRef.close();
    }
  }
}
