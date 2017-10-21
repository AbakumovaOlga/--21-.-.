import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JComboBox;
import javax.swing.JOptionPane;
import javax.swing.JSpinner;
import javax.swing.JLabel;
import javax.swing.JCheckBox;
import javax.swing.JRadioButton;
import javax.swing.ButtonGroup;
import javax.swing.JButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class App {

	private JFrame frame;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	private final ButtonGroup buttonGroup_1 = new ButtonGroup();
	private Egg[] eggs;

	private Salt salt;

	private WaterTap waterTap;

	private Knife knife;

	private Pan pan;

	private Stove stove;

	private Butter butter;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					App window = new App();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public App() {
		initialize();
	}

	private void initialize() {
		waterTap = new WaterTap();
		knife = new Knife();
		pan = new Pan();
		stove = new Stove();
		butter = new Butter();
		salt = new Salt();

		frame = new JFrame();
		frame.setBounds(100, 100, 848, 575);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JSpinner spinner = new JSpinner();
		spinner.setBounds(27, 76, 63, 34);
		frame.getContentPane().add(spinner);

		JLabel label = new JLabel("\u042F\u0439\u0446\u0430");
		label.setBounds(105, 83, 69, 20);
		frame.getContentPane().add(label);

		JCheckBox FButter = new JCheckBox("\u041C\u0430\u0441\u043B\u043E");
		FButter.setBounds(27, 117, 139, 29);
		frame.getContentPane().add(FButter);
		FButter.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				butter.SetCount(true);
			}
		});

		JCheckBox FSalt = new JCheckBox("\u0421\u043E\u043B\u044C");
		FSalt.setBounds(27, 154, 139, 29);
		frame.getContentPane().add(FSalt);
		FSalt.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				salt.SetCount(true);
			}
		});

		JRadioButton FOpen = new JRadioButton(
				"\u041E\u0442\u043A\u0440\u044B\u0442");
		buttonGroup.add(FOpen);
		FOpen.setBounds(288, 79, 155, 29);
		frame.getContentPane().add(FOpen);
		FOpen.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				waterTap.SetOpen(true);
			}
		});

		JRadioButton FClose = new JRadioButton(
				"\u0417\u0430\u043A\u0440\u044B\u0442");
		FClose.setSelected(true);
		buttonGroup.add(FClose);
		FClose.setBounds(288, 117, 155, 29);
		frame.getContentPane().add(FClose);
		FClose.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				waterTap.SetOpen(false);
			}
		});

		JLabel label_1 = new JLabel("\u041A\u0440\u0430\u043D");
		label_1.setBounds(293, 47, 69, 20);
		frame.getContentPane().add(label_1);

		JRadioButton FOn = new JRadioButton("\u0412\u043A\u043B");
		buttonGroup_1.add(FOn);
		FOn.setBounds(520, 79, 155, 29);
		frame.getContentPane().add(FOn);
		FOn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				stove.SetState(true);
			}
		});

		JRadioButton FOff = new JRadioButton("\u0412\u044B\u043A\u043B");
		FOff.setSelected(true);
		buttonGroup_1.add(FOff);
		FOff.setBounds(520, 117, 155, 29);
		frame.getContentPane().add(FOff);
		FOn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				stove.SetState(false);
			}
		});

		JButton FWash = new JButton(
				"\u041C\u044B\u0442\u044C \u044F\u0439\u0446\u0430");
		FWash.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (eggs == null) {
					JOptionPane
							.showMessageDialog(frame,
									"Яиц то нет, что мыть? Допустим, что руки уже чистые :)");
					return;
				}

				if (eggs.length == 0) {
					JOptionPane
							.showMessageDialog(frame,
									"Яиц то нет, что мыть? Допустим, что руки уже чистые :)");
					return;
				}
				if (!waterTap.GetOpen()) {
					JOptionPane.showMessageDialog(frame,
							"Кран закрыт, как мыть?");
					return;
				}
				pan.Init(eggs.length);

				for (int i = 0; i < eggs.length; ++i) {
					eggs[i].SetDirty(false);
				}
				FClose.setSelected(true);
				JOptionPane.showMessageDialog(frame,
						"Яйца помыли, можно разбивать");

			}
		});
		FWash.setBounds(59, 240, 115, 29);
		frame.getContentPane().add(FWash);

		JButton FHit = new JButton(
				"\u0420\u0430\u0437\u0431\u0438\u0442\u044C \u044F\u0439\u0446\u0430");
		FHit.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (eggs == null) {
					JOptionPane.showMessageDialog(frame,
							"Яиц то нет, что разбивать собрались?");
					return;
				}

				if (eggs.length == 0) {
					JOptionPane.showMessageDialog(frame,
							"Яиц то нет, что разбивать собрались?");
					return;
				}

				for (int i = 0; i < eggs.length; ++i) {
					if (eggs[i].GetDirty()) {
						JOptionPane.showMessageDialog(frame,
								"Они же грязные! Фу!");
						return;
					}
				}

				if (!butter.GetCount()) {
					JOptionPane.showMessageDialog(frame, "Без масла пригорит");
					return;
				} else {
					butter = new Butter();
					pan.AddButter(butter);
				}
				for (int i = 0; i < eggs.length; ++i) {
					knife.Hit(eggs[i]);
					pan.AddEgg(eggs[i]);
				}
				JOptionPane.showMessageDialog(frame,
						"Яйца разбили на сковороду. Можно готовить");

			}
		});
		FHit.setBounds(59, 301, 129, 29);
		frame.getContentPane().add(FHit);

		JButton FCook = new JButton(
				"\u0413\u043E\u0442\u043E\u0432\u0438\u0442\u044C ");
		FCook.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (!stove.GetState()) {
					JOptionPane
							.showMessageDialog(frame,
									"Ну это мы так долго будем готовить! Плиту включите.");
					return;
				}

				if (!salt.GetCount()) {
					JOptionPane.showMessageDialog(frame, "Без соли не вкусно");
					return;
				} else {
					salt = new Salt();
					pan.AddSalt(salt);
				}

				stove.SetPan(pan);

				if (!pan.Check()) {
					JOptionPane.showMessageDialog(frame, "Чего-то не хватает");
					return;
				} else
					stove.Cooking();

				if (pan.IsReady()) {
					FOff.setSelected(true);
					JOptionPane.showMessageDialog(frame, "Яйца пожарились!");
				}
			}
		});
		FCook.setBounds(59, 364, 129, 29);
		frame.getContentPane().add(FCook);

		JButton FGet = new JButton(
				"\u041F\u043E\u043B\u043E\u0436\u0438\u0442\u044C \u044F\u0438\u0447\u043D\u0438\u0446\u0443 \u043D\u0430 \u0442\u0430\u0440\u0435\u043B\u043A\u0443");
		FGet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				stove.SetPan(pan);

				if (!pan.Check()) {
					JOptionPane.showMessageDialog(frame, "Чего-то не хватает");
					return;
				}

				if (pan.IsReady()) {
					eggs = pan.GetEggs();
					JOptionPane.showMessageDialog(frame,
							"Мы сделали это! Приятного аппетита!");
				}
				if (!pan.IsReady()) {
					JOptionPane
							.showMessageDialog(
									frame,
									"Ну сырые яйца - это, наверное, тоже съедобно. Но может все-таки приготовим их сначала");
					return;
				}

			}
		});
		FGet.setBounds(352, 333, 284, 56);
		frame.getContentPane().add(FGet);

		JButton btnNewButton = new JButton("OK");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				spinner.setEnabled(false);
				eggs = new Egg[Integer.parseInt((spinner.getValue()).toString())];

				for (int i = 0; i < eggs.length; ++i) {
					eggs[i] = new Egg();
				}
			}
		});
		btnNewButton.setBounds(147, 79, 53, 29);
		frame.getContentPane().add(btnNewButton);

		JLabel label_2 = new JLabel("\u041F\u043B\u0438\u0442\u0430");
		label_2.setBounds(514, 47, 69, 20);
		frame.getContentPane().add(label_2);
	}
}
