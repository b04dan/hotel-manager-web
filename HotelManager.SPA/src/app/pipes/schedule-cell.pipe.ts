import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'scheduleCell'
})
export class ScheduleCellPipe implements PipeTransform {

  transform(value?: number): string {
    return value ? value + ' этаж' : 'Выходной';
  }
}
