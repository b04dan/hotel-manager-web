import {Component, Input, EventEmitter, Output} from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  @Input() isMenuOpened = true;
  @Output() isShowSidebar = new EventEmitter<boolean>();

  public openMenu(): void {
    this.isMenuOpened = !this.isMenuOpened;
    this.isShowSidebar.emit(this.isMenuOpened);
  }
}
