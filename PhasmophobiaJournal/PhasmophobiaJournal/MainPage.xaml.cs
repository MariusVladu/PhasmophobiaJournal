using System;
using PhasmophobiaJournal.BusinessLogic;
using PhasmophobiaJournal.Domain;
using PhasmophobiaJournal.Domain.ViewModels;
using PhasmophobiaJournal.Mappers;
using PhasmophobiaJournal.Providers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PhasmophobiaJournal.Domain.Extensions;
using Xamarin.Forms;

namespace PhasmophobiaJournal
{
    public partial class MainPage : ContentPage
    {
        private EvidenceAnalyzer evidenceAnalyzer;
        private EvidenceStateHandler evidenceStateHandler;
        private EvidenceStateMapper evidenceStateMapper;
        private EvidenceMapper evidenceMapper;

        public MainPageVM MainPageVM;

        public MainPage()
        {
            InitializeComponent();

            Initialize();
            BindingContext = MainPageVM;
        }

        private void Initialize()
        {
            evidenceAnalyzer = new EvidenceAnalyzer(new PhasmophobiaGhostsProvider());
            evidenceStateHandler = new EvidenceStateHandler();
            evidenceStateMapper = new EvidenceStateMapper();
            evidenceMapper = new EvidenceMapper();
            
            MainPageVM = new MainPageVM();
            MainPageVM.Evidences = new ObservableCollection<EvidenceStateVM>();

            foreach (var evidenceState in evidenceStateHandler.GetInitialEvidenceStates())
                MainPageVM.Evidences.Add(evidenceStateMapper.GetEvidenceStateVM(evidenceState));

            HandleEvidences(new List<Evidence>(), new List<Evidence>());
        }

        private void OnEvidenceSelected(object sender, SelectionChangedEventArgs e)
        {
            var selectedEvidences = e.CurrentSelection
                .Select(x => evidenceMapper.GetEvidence(((EvidenceStateVM)x).Evidence))
                .ToList();

            var excludedEvidences = GetExcludedEvidences()
                .Except(selectedEvidences)
                .ToList();

            HandleEvidences(selectedEvidences, excludedEvidences);
        }

        private void ToggleExcludedEvidence(object sender, EventArgs e)
        {
            var evidenceToToggleString = ((Button) sender).BindingContext as string;
            var evidenceToToggle = evidenceMapper.GetEvidence(evidenceToToggleString);

            var currentEvidences = GetCurrentEvidences();
            var excludedEvidences = GetExcludedEvidences();


            if (excludedEvidences.Contains(evidenceToToggle))
            {
                excludedEvidences.Remove(evidenceToToggle);
            }
            else
            {
                excludedEvidences.Add(evidenceToToggle);
                currentEvidences.Remove(evidenceToToggle);
            }

            HandleEvidences(currentEvidences, excludedEvidences);
        }

        private List<Evidence> GetCurrentEvidences()
        {
            return MainPageVM.Evidences
                .Where(x => x.State == State.Current.GetDescription())
                .Select(x => evidenceMapper.GetEvidence(x.Evidence))
                .ToList();
        }

        private List<Evidence> GetExcludedEvidences()
        {
            return MainPageVM.Evidences
                .Where(x => x.State == State.Excluded.GetDescription())
                .Select(x => evidenceMapper.GetEvidence(x.Evidence))
                .ToList();
        }

        private void HandleEvidences(List<Evidence> currentEvidences, List<Evidence> excludedEvidences)
        {
            var analyzeResult = evidenceAnalyzer.Analyze(currentEvidences, excludedEvidences);
            var newEvidenceStates = evidenceStateHandler.GetEvidencesState(analyzeResult);

            UpdateEvidences(newEvidenceStates);
            MainPageVM.PossibleGhosts = $"Possible Ghosts: {string.Join(", ", analyzeResult.PossibleGhosts.Select(g => g.Type))}";
        }

        private void UpdateEvidences(List<EvidenceState> newEvidenceStates)
        {
            var newEvidenceStatesVM = newEvidenceStates
                .Select(evidenceStateMapper.GetEvidenceStateVM)
                .ToList();

            for (int i = 0; i < MainPageVM.Evidences.Count; i++)
                MainPageVM.Evidences[i].State = newEvidenceStatesVM[i].State;
        }
    }
}
