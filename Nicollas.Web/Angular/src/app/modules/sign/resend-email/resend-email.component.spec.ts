import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResendEmailComponent } from './resend-email.component';

import { FormsModule } from '@angular/forms';

describe('ResendEmailComponent', () => {
  let component: ResendEmailComponent;
  let fixture: ComponentFixture<ResendEmailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({imports: [ FormsModule ],
      declarations: [ ResendEmailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResendEmailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});