import { Component } from '@angular/core';
import { Todo } from '../models/todo';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ChangeDetectorRef } from '@angular/core';



@Component({
  selector: 'app-todo-list',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './todo-list.component.html',
  styleUrl: './todo-list.component.css'
})
export class TodoListComponent {
i: any;
priority: any;
removeTask(index: number) {
this.todo.splice(index, 1);
}
  todo:Todo[] = [
    { task: "Finish Lab", completed: false, duration: 360, priority: 'HIGH'},
    { task: "Do laundry", completed: false, duration: 45, priority: 'LOW'},
    { task: "Water plants", completed: true, duration: 60, priority: "NORMAL"}
  ];

  task:string = "";
  completed:boolean = false;
  duration:number = 0;

  addTodo() : void {
    if (this.task && this.duration > 0) {
    this.todo.push({
      task: this.task, 
      completed: this.completed,
      duration: this.duration});
    
    this.task = "";
    this.completed = false;
    this.duration = 0;
    }
  }
  completeTask(index: number): void { 
    this.todo[index].completed = true;
  }
  constructor(private cdr: ChangeDetectorRef) {}

  deleteTask(index: number): void {
    if (index >= 0 && index < this.todo.length) {  // Check for a valid index
        this.todo.splice(index, 1);
        this.cdr.detectChanges();  // Manually triggers change detection
    } else {
        console.error('Index out of bounds');
    }
}



}
