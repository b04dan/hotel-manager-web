import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'residenceDate'
})
export class ResidenceDatePipe implements PipeTransform {

  transform(value: Date | string): string {
    return value ? new Date(value).toLocaleDateString('ru-UA') : 'Проживает';
  }

}
